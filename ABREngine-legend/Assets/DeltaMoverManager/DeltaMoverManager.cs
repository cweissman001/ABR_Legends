using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

#if UNITY_EDITOR

using UnityEditor.Recorder;
using UnityEditor;

[ExecuteAlways]
public class DeltaMoverManager : MonoBehaviour
{


    [HideInInspector] public DeltaMover[] childMovers { get; set; }
    [HideInInspector] public Camera camera { get; set; }
    public bool animate;
    public bool animateOnPlay;
    public bool setStart;
    public bool resetState;

    public string saveName;

    public bool record;
    public string recordName;
    private string persistentDataPath;

    public List<string> saves = new List<string>();
    RecorderWindow recorderWindow;


    void Awake() {
        this.persistentDataPath = Path.Combine(Application.persistentDataPath, "media", "cameramoves");
    }

    public void SaveState()
    {


        using (StreamWriter writetext = new StreamWriter(Path.Combine(this.persistentDataPath, saveName + ".cameramove")))
        {
            foreach (var cm in childMovers)
            {
                cm.WriteToStream(writetext);
            }
            writetext.WriteLine(camera.fieldOfView.ToString());

        }

        if (saves.Contains(saveName) == false) saves.Add(saveName);
    }

    public void LoadState(string saveName)
    {
        using (StreamReader readtext = new StreamReader(Path.Combine(this.persistentDataPath, saveName + ".cameramove")))
        {
            foreach (var cm in childMovers)
            {
                cm.ReadFromStream(readtext);
            }
            camera.fieldOfView = float.Parse(readtext.ReadLine());
        }

        resetState = true;

        animate = false;
    }
    public void ShowState(string saveName)
    {

        var itemPath = Path.Combine(this.persistentDataPath, saveName + ".cameramove").Replace(@"/", @"\");   // explorer doesn't like front slashes
        System.Diagnostics.Process.Start("explorer.exe", "/select," + itemPath);
    }
    Queue<string> toDelete = new Queue<string>();
    public void DeleteState(string saveName)
    {
        if (File.Exists(Path.Combine(this.persistentDataPath, saveName + ".cameramove")))
            File.Delete(Path.Combine(this.persistentDataPath, saveName + ".cameramove"));
        toDelete.Enqueue(saveName);
    }

    bool isRecording = false;
    bool isAnimating = false;
    public bool IsAnimating()
    {
        return isAnimating;
    }

    public bool IsRecording()
    {
        return isRecording;
    }

    public void StartRecording()
    {
        StopRecording();
        isRecording = true;
        recorderWindow.StartRecording();
        RestartAnimation();
        ResumeAnimating();
    }
    public void StopRecording()
    {
        if (isRecording)
        {
            isRecording = false;
            recorderWindow.StopRecording();
        }

    }

    public void ResumeAnimating()
    {
        isAnimating = true;
        foreach (var mover in childMovers)
        {
            mover.animate = true;
        }
    }

    public void PauseAnimating()
    {
        isAnimating = false;
        foreach (var mover in childMovers)
        {
            mover.animate = false;
        }
    }

    public void RestartAnimation()
    {
        foreach (var mover in childMovers)
        {
            mover.resetState = true;
            EditorUtility.SetDirty(mover);
        }
        EditorUtility.SetDirty(this);
    }

        public void SetStartState()
    {
        foreach (var mover in childMovers)
        {
            mover.saveState = true;

        }
        setStart = false;

    }

    // Use this for initialization
    void Start()
    {
        recorderWindow = EditorWindow.GetWindow<RecorderWindow>();
        saves.Clear();
        if (Directory.Exists(this.persistentDataPath) == false)
            Directory.CreateDirectory(this.persistentDataPath);
        DirectoryInfo d = new DirectoryInfo(this.persistentDataPath);
        FileInfo[] Files = d.GetFiles("*.cameramove"); //Getting Text files
        foreach (FileInfo file in Files)
        {
            saves.Add(Path.GetFileNameWithoutExtension(file.FullName));
        }

        childMovers = GetComponentsInChildren<DeltaMover>();
        foreach (var cm in childMovers)
        {
            if ((camera = cm.GetComponent<Camera>()) != null) break;

        }
        if (Application.isPlaying)
        {
            if (animateOnPlay) animate = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (IsAnimating())
            EditorUtility.SetDirty(this);
        while (toDelete?.Count > 0)
        {
            saves.Remove(toDelete.Dequeue());
        }
    }


    void OnApplicationQuit()
    {
        var recorderWindow = EditorWindow.GetWindow<RecorderWindow>();

        recorderWindow.StopRecording();
    }
}
#endif