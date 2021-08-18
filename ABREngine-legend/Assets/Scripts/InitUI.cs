using System;
using System.IO;
using UnityEngine;

public class InitUI : MonoBehaviour
{
    public bool restartServer = false;
    private string sourceDir;
    private string destinationDir;
    private string mediaDir;
    private string serverName = "ABRDesignInterface";

    private string pythonPath = "";
    private string[] pythonPaths = {
        Path.Combine(
            "/usr",
            "bin",
            "python3"
        ),
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Programs",
            "Python",
            "Python37",
            "python.exe"
        ),
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
            "Python37",
            "python.exe"
        )
    };

    private System.Diagnostics.Process uiServer;
    private System.Diagnostics.Process mediaServer;

    void Awake()
    {
        this.sourceDir = Path.Combine(Application.streamingAssetsPath, this.serverName);
        this.destinationDir = Path.Combine(Application.persistentDataPath, this.serverName);
        this.mediaDir = Path.Combine(this.destinationDir, "..", "media");
    }

    // Start is called before the first frame update
    void Start()
    {
        foreach (var path in pythonPaths) {
            if (File.Exists(path)) {
                this.pythonPath = path;
                break;
            }
        }

        if (this.pythonPath == "") {
            var errorText = "Python 3.7 is not found at any of the following locations:";
            foreach (var path in pythonPaths) {
                errorText += "\n" + path;
            }
            Debug.LogError(errorText);
            ScreenLogger.Instance.Log(errorText);
        }

        CopyContents();
        StartServers();
    }

    void OnDestroy() {
        KillServers();
    }

    void Update() {
        if (this.restartServer) {
            this.restartServer = false;
            this.KillServers();
            this.CopyContents();
            this.StartServers();
        }
    }

    void CopyContents() {
        // Create the parent destination directory
        Directory.CreateDirectory(this.destinationDir);

        // Now create all of the subdirectories
        // https://stackoverflow.com/a/3822913
        foreach (string dirPath in Directory.GetDirectories(this.sourceDir, "*", 
                SearchOption.AllDirectories)) {
            Directory.CreateDirectory(dirPath.Replace(this.sourceDir, this.destinationDir));
        }

        // Copy all the files & replace any files with the same name
        Debug.Log("Copying all server files");
        foreach (string newPath in Directory.GetFiles(this.sourceDir, "*.*", 
                SearchOption.AllDirectories)) {
            try {
                File.Copy(newPath, newPath.Replace(this.sourceDir, this.destinationDir), true);
            } catch (System.UnauthorizedAccessException e) {
                Debug.LogError(e);
            }
        }

        // Silence django warnings
        System.Diagnostics.Process migrate = new System.Diagnostics.Process();

        migrate.StartInfo.WorkingDirectory = destinationDir;
        migrate.StartInfo.FileName = this.pythonPath;
        migrate.StartInfo.Arguments = "manage.py migrate --no-input";
        Debug.Log("Migrating Django");
        migrate.Start();

        // Collect static files within the destination directory
        System.Diagnostics.Process staticFileCollection = new System.Diagnostics.Process();

        staticFileCollection.StartInfo.WorkingDirectory = destinationDir;
        staticFileCollection.StartInfo.FileName = this.pythonPath;
        staticFileCollection.StartInfo.Arguments = "manage.py collectstatic --no-input";
        Debug.Log("Collecting static files");
        staticFileCollection.Start();

        // Wait for django to finish
        while (!staticFileCollection.HasExited);

        Debug.Log("Finished copying and collecting static files");
    }

    void StartServers() {
        // Run the UI server
        this.uiServer = new System.Diagnostics.Process();

        this.uiServer.StartInfo.WorkingDirectory = destinationDir;
        this.uiServer.StartInfo.FileName = this.pythonPath;
        this.uiServer.StartInfo.Arguments = "manage.py runserver 0.0.0.0:8000";
        this.uiServer.Start();

        // Run the basic media server
        this.mediaServer = new System.Diagnostics.Process();

        this.mediaServer.StartInfo.WorkingDirectory = mediaDir;
        this.mediaServer.StartInfo.FileName = this.pythonPath;
        this.mediaServer.StartInfo.Arguments = Path.Combine("..", this.serverName, "cors_server.py");
        this.mediaServer.Start();
    }

    void KillServers() {
        System.Diagnostics.Process killer = new System.Diagnostics.Process();

#if (UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN)
        killer.StartInfo.FileName = "taskkill";
        // This doesn't actually seem to kill the server
        // killer.StartInfo.Arguments = string.Format("/PID {0} /F", this.uiServer.Id);
        // So we use this instead (more dangerous):
        killer.StartInfo.Arguments = "/IM python.exe /F";
#elif (UNITY_EDITOR_LINUX || UNITY_STANDALONE_LINUX)
        killer.StartInfo.FileName = "killall";
        killer.StartInfo.Arguments = "python3";
#endif

        killer.Start();
        while (!this.uiServer.HasExited && !this.mediaServer.HasExited);
        Debug.Log("Killed UI and media servers");
        ABRMessenger.Instance.ForceDisconnect();
    }

}
