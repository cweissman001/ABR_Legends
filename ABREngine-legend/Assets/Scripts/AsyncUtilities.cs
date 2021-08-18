using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using UnityEngine;

public static class AsyncUtilities
{
    public static async Task UntilTrue(Func<bool> test)
    {
        while (test.Invoke() == false)
        {
            await Task.Delay(25);
        }
    }
    public static int ReadIntFromSocket(Socket s)
    {
        byte[] integerBytes = new byte[4];
        s.Receive(integerBytes);

        if (System.BitConverter.IsLittleEndian)
        {
            System.Array.Reverse(integerBytes);
        }

        int integer = System.BitConverter.ToInt32(integerBytes, 0);

        return integer;
    }
    public static async Task<byte[]> ReadBytesFromSocketAsync(Socket s, int numBytes)
    {
        byte[] dataBytes = new byte[numBytes];
        int totalBytesReceived = 0;

        while (totalBytesReceived < numBytes)
        {
            int offset = totalBytesReceived;
            int count = numBytes - totalBytesReceived;
            ArraySegment<byte> arraySegment = new ArraySegment<byte>(dataBytes, offset, count);
            var bytesReadTask = s.ReceiveAsync(arraySegment, SocketFlags.None);
            var bytesReceived = await bytesReadTask;
            totalBytesReceived += bytesReceived;
        }
        return dataBytes;
    }
    public static byte[] ReadBytesFromSocket(Socket s, int numBytes)
    {
        byte[] dataBytes = new byte[numBytes];
        int totalBytesReceived = 0;

        while (totalBytesReceived < numBytes)
        {
            int offset = totalBytesReceived;
            int count = numBytes - totalBytesReceived;
            var bytesReceived = s.Receive(dataBytes, offset, count, SocketFlags.None);
            totalBytesReceived += bytesReceived;
        }
        return dataBytes;
    }
    public static async Task<string> ReadStringFromSocketAsync(Socket s, int numChars)
    {
        Task<byte[]> bytesReceivedTask = ReadBytesFromSocketAsync(s, numChars);


        byte[] bytesReceived = await bytesReceivedTask;

        string text = System.Text.Encoding.UTF8.GetString(bytesReceived, 0, bytesReceived.Length);
        return text;
    }
    public static string ReadStringFromSocket(Socket s, int numChars)
    {
        var bytesReceived = ReadBytesFromSocket(s, numChars);

        string text = System.Text.Encoding.UTF8.GetString(bytesReceived, 0, bytesReceived.Length);
        return text;
    }
    public static async Task SendStringToSocketAsync(Socket s, string text)
    {
        byte[] bytesToSend = System.Text.Encoding.UTF8.GetBytes(text);
        int totalBytesSent = 0;
        while (totalBytesSent < bytesToSend.Length)
        {
            int offset = totalBytesSent;
            int count = bytesToSend.Length - totalBytesSent;
            ArraySegment<byte> arraySegment = new ArraySegment<byte>(bytesToSend, offset, count);
            var bytesSent = await s.SendAsync(arraySegment, SocketFlags.None);
            totalBytesSent += bytesSent;
        }
    }

    public static void SendStringToSocket(Socket s, string text)
    {
        byte[] bytesToSend = System.Text.Encoding.UTF8.GetBytes(text);
        int totalBytesSent = 0;
        while (totalBytesSent < bytesToSend.Length)
        {
            int offset = totalBytesSent;
            int count = bytesToSend.Length - totalBytesSent;
            var bytesSent = s.Send(bytesToSend, offset, count, SocketFlags.None);
            totalBytesSent += bytesSent;
        }
    }
}
