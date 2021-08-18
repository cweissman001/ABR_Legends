/* AbrMessenger.cs
 * 
 * Copyright (c) 2020, University of Minnesota
 * Author: Bridger Herman <herma582@umn.edu>
 *
 * Sends and receives messages from the in-browser ABR design client, via way
 * of the intermediary Python server
 */

using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System;
using System.Linq;

[System.Serializable]
public enum AbrMessageType {
    State,              // 0
    Update,             // 1
    StateRequest,       // 2
    ReloadVisAsset,     // 3
    CreateStateVisAsset,// 4
    EngineDisconnect,   // 5
    LegendViewRequest,  // 6
    LegendView,         // 7
    _e,                 // 8 (deprecated)
}

[System.Serializable]
public class AbrMessage {
    public AbrMessageType type;
    public string message;

    public AbrMessage(AbrMessageType t, string inMessage) {
        type = t;
        message = inMessage;
    }
}


/// Delegate to be called when an AbrMessage is received from the client
public delegate void AbrMessageHandler(AbrMessage message);

public class ABRMessenger : MonoBehaviour
{
    /// Address and port that the design Python server is running on
    public string address = "127.0.0.1";
    public int port = 9000;

    /// Buffer size for transferring data to/from design server (must match
    /// BUF_SIZE in abr_msg_recv.py!)
    private const int BUF_SIZE = 4096;

    /// How long to wait before determining that the client is dead (milliseconds)
    private const int TIMEOUT = 2000;

    /// Connection to the design server
    private TcpListener _server;

    /// Is the connection thread running?
    private bool _running;

    /// Whether or not the engine is connected to the ABR server
    private bool _serverConnected = false;

    /// Thread to listen for data across the socket
    private Thread _socketThread;

    /// Queue for messages to be sent to the design client via way of the design server
    private Queue<AbrMessage> _outgoingMessages = new Queue<AbrMessage>();
    private readonly object _outgoingLock = new object();

    /// Callback for all subscribers to AbrMessages
    public AbrMessageHandler OnAbrMessage { get; set; }

    /// Static instance of this class so the singleton can be accessed from all
    /// over
    private static ABRMessenger _instance;
    public static ABRMessenger Instance
    {
        get { return _instance; }
    }

    void OnEnable()
    {
        if (!Instance)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Tell the ABR Server we've disconnected, then clean up connections and threads
    void OnDestroy()
    {
        AbrMessage disconnectMsg = new AbrMessage(AbrMessageType.EngineDisconnect, "Engine Disconnected");
        this.SendAbrMessage(disconnectMsg);
        this._running = false;
        this._socketThread.Join();
        this._server.Stop();
        Debug.Log("Disconnected from ABR Server and exited thread");
    }

    // Start is called before the first frame update
    void Start()
    {
        this._server = new TcpListener(IPAddress.Parse(address), port);
        this._server.Start();
        this._socketThread = new Thread(new ThreadStart(this.SocketServer));
        this._socketThread.Start();
    }

    public void SendAbrMessage(AbrMessage message)
    {
        if (this._serverConnected)
        {
            lock (this._outgoingLock) {
                // Debug.Log("Queuing message: (Type:" + message.type + ") " + message.message.Substring(0,Math.Min(2048,message.message.Length)));
                this._outgoingMessages.Enqueue(message);
            }
        }
    }

    public void ForceDisconnect() {
        this._serverConnected = false;
    }

    void SocketServer()
    {
        this._running = true;
        while (this._running)
        {
            Debug.Log(string.Format("Listening for design server connections on {0}:{1}", address, port));
            Task<TcpClient> serverConnectionTask = this._server.AcceptTcpClientAsync();

            // Wait for the server to connect, or to be interrupted
            while (this._running && !serverConnectionTask.IsCompleted && !serverConnectionTask.IsCanceled);

            if (!this._running || serverConnectionTask.IsCanceled) {
                break;
            }

            this._serverConnected = true;

            TcpClient abrServerConnection = serverConnectionTask.Result;
            NetworkStream stream = abrServerConnection.GetStream();
            stream.ReadTimeout = TIMEOUT;
            stream.WriteTimeout = TIMEOUT;
            Debug.Log("Connected to design server");

            while (this._serverConnected && (this._running || this._outgoingMessages.Count > 0))
            {
                while (this._outgoingMessages.Count > 0)
                {
                    // Convert the message to bytes
                    lock (this._outgoingLock) {
                        AbrMessage msg = this._outgoingMessages.Peek();
                        string strMsg = JsonUtility.ToJson(msg);
                        byte[] byteMsg = System.Text.Encoding.ASCII.GetBytes(strMsg);

                        // Get the message's length and send it across (assume Little-Endian)
                        byte[] lengthBytes = BitConverter.GetBytes(byteMsg.Length);
                        if (!BitConverter.IsLittleEndian)
                        {
                            Array.Reverse(lengthBytes);
                        }
                        try {
                            stream.Write(lengthBytes, 0, lengthBytes.Length);
                        } catch (SocketException e) {
                            Debug.LogError(e);
                            this._serverConnected = false;
                        }

                        // Send the message
                        try {
                            stream.Write(byteMsg, 0, byteMsg.Length);
                        } catch (SocketException e) {
                            Debug.LogError(e);
                            this._serverConnected = false;
                        }
                        // Don't actually dequeue the message until it's
                        // properly sent
                        this._outgoingMessages.Dequeue();
                    }
                }

                while (stream.DataAvailable)
                {
                    // Get the message's length from the stream
                    byte[] recvLengthBytes = new byte[sizeof(int)];
                    try {
                        stream.Read(recvLengthBytes, 0, sizeof(int));
                    } catch (SocketException e) {
                        Debug.LogError(e);
                        this._serverConnected = false;
                    }

                    // Assume Little-Endianness
                    if (!BitConverter.IsLittleEndian)
                    {
                        Array.Reverse(recvLengthBytes);
                    }

                    int messageLength = BitConverter.ToInt32(recvLengthBytes, 0);
                    if (messageLength == 0)
                    {
                        break;
                    }

                    // Get the actual message from the client
                    byte[] buffer = new byte[BUF_SIZE];
                    List<byte> messageBytes = new List<byte>();
                    int totalBytesRead = 0;
                    while (totalBytesRead < messageLength)
                    {
                        int bytesRead = 0;
                        try {
                            bytesRead = stream.Read(buffer, 0, Math.Min(messageLength - totalBytesRead, BUF_SIZE));
                        } catch (SocketException e) {
                            Debug.LogError(e);
                            this._serverConnected = false;
                        }
                        if (bytesRead > 0)
                        {
                            // Discard any null bytes at the end of the buffer
                            var filteredBuffer = buffer.Take(bytesRead);
                            messageBytes.AddRange(filteredBuffer);
                        }
                        totalBytesRead += bytesRead;
                    }

                    // Decode the message from its bytes
                    string message = System.Text.Encoding.ASCII.GetString(messageBytes.ToArray());

                    AbrMessage recvMsg = JsonUtility.FromJson<AbrMessage>(message);

                    // Send the AbrMessage to all subscribers
                    // Debug.Log("Receiving Message: " + recvMsg.message);
                    this.OnAbrMessage(recvMsg);
                }
            }
            this._running = false;
            abrServerConnection.Close();
        }
    }
}
