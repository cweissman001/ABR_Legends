using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using static AsyncUtilities;
using System;
using System.Threading.Tasks;
using UnityEditor;

public class BoolReference
{
    public BoolReference(bool b)
    {
        this.state = b;
    }
    public static implicit operator BoolReference(bool b) { return new BoolReference(b); }

    public static implicit operator bool(BoolReference b)
    {
        return b is BoolReference && b.state;
    }

    public bool state = false;
}



public class ParaviewDataListener : MonoBehaviour
{
    public int port = 1900;

    [SerializeField]
    public TcpListener listener = null;

    private DataManager _dataManager;

    private DataManager dataManager
    {
        get
        {
            if (_dataManager == null) _dataManager = GetComponent<DataManager>();
            return _dataManager;
        }
    }

    Queue<Action> updateActions = new Queue<Action>();

    List<Task> handlingTasks = new List<Task>();

    Queue<string> logLines = new Queue<string>();

    void Log(string message)
    {
        lock (logLock)
        {
            logLines.Enqueue("[" + System.DateTime.UtcNow.ToString("HH:mm:ss:ff") + "]" + message);
        }
    }

    [TextArea(25, 25)]
    public string log;

    public void StartServer()
    {
        if (listener != null) return;
        listener = new TcpListener(port: port, localaddr: IPAddress.Any);
        listener.Start();
        listener.BeginAcceptSocket(
            new System.AsyncCallback(DoAcceptSocketCallback), listener);
    }

    public void StopServer()
    {
        listener.Stop();
        listener = null;
    }

    static async Task<string> GetParaviewTextAsync(Socket clientSocket)
    {

        int bytesInText = ReadIntFromSocket(clientSocket);
        string text = await ReadStringFromSocketAsync(clientSocket, bytesInText);
        return text;
    }
    static async Task<string> GetParaviewLabelAsync(Socket clientSocket)
    {

        int bytesInLabel = ReadIntFromSocket(clientSocket);
        string label = await ReadStringFromSocketAsync(clientSocket, bytesInLabel);
        return label;
    }

    struct ParaviewTextData
    {
        public string label;
        public string data;
    }

    static async Task<ParaviewTextData> GetParaviewTextDataAsync(Socket clientSocket)
    {
        string data = "";
        string labelText = await GetParaviewTextAsync(clientSocket);
        if (labelText != "update")
        {
            var asciiDataTask = GetParaviewTextAsync(clientSocket);
            data = await asciiDataTask;
        }

        return new ParaviewTextData
        {
            label = labelText,
            data = data
        };
    }
    public void DoAcceptSocketCallback(IAsyncResult ar)
    {
        TcpListener listener = (TcpListener)ar.AsyncState;
        // End the operation and display the received data on the
        //console.
        Socket clientSocket = listener.EndAcceptSocket(ar);
        Debug.Log("Handling a connection");
        Task.Run(async () =>
        {

            var textDataTask = GetParaviewTextDataAsync(clientSocket);

            ParaviewTextData textData = await textDataTask;
            VTK.vtkUnstructuredGrid unstructuredGrid = null;
            Debug.Log("Accepting data stream for label \"" + textData.label + "\"");
            if (textData.label != "update")
            {
                // We don't need to wait to send "ok" because this isn't an update. 
                // We do, however, need to first log that there's a dataset to handle
                // to make the update wait for it. 
                
                BoolReference handlingDone = new BoolReference(false);
                handlingTasks.Add(UntilTrue(() => handlingDone == true));

                await SendStringToSocketAsync(clientSocket, "ok");
                Debug.Log("Sent label \"" + textData.label + "\" " + " ok");

                VTK.vtkUnstructuredGridReader rdr = VTK.vtkUnstructuredGridReader.New();
                rdr.ReadFromInputStringOn();
                rdr.SetInputString(textData.data);

                rdr.Update();
                unstructuredGrid = rdr.GetOutput(0);


                updateActions.Enqueue(() =>
                {
                    dataManager.HandleVtkDataset(textData.label, unstructuredGrid, true, handlingDone);
                });
                

            }
            else
            {
                Debug.Log("Waiting for all objects to update...");
                await Task.WhenAll(handlingTasks);
                handlingTasks.Clear();
                await SendStringToSocketAsync(clientSocket, "up");
                Debug.Log("All objects have been unpacked, Sent label \"" + textData.label + "\" "  + " ok");
                dataManager.ReleaseHold();
            }



        });



        listener.BeginAcceptSocket(
           new System.AsyncCallback(DoAcceptSocketCallback), listener);

    }


    // Start is called before the first frame update
    void Start()
    {
        StartServer();
    }

    private void OnDestroy()
    {
        StopServer();
    }

    object logLock = new object();
    // Update is called once per frame
    void Update()
    {
        while (updateActions.Count > 0)
        {
            updateActions.Dequeue().Invoke();
        }



        while (logLines.Count > 25)
        {
            logLines.Dequeue();
        }

        log = "";
        lock(logLock)
        {
            foreach (var line in logLines)
            {
                log += line + "\n";
            }
        }

    }
}

