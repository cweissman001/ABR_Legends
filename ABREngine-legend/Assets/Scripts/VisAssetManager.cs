using Dummiesman;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;



public class VisAssetManager : MonoBehaviour
{
    public GameObject defaultPrefab;

    public const string VISASSET_JSON = "artifact.json";

    static VisAssetManager _instance;
    public static VisAssetManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<VisAssetManager>();
            if (_instance == null)
                _instance = new GameObject("Vis Asset Manager").AddComponent<VisAssetManager>();
            return _instance;
        }
    }
    private void Awake()
    {
        var i = Instance;
    }
    public static Texture GetDefaultAlbedo()
    {
        var mat = Instance.defaultPrefab.GetComponent<MeshRenderer>().sharedMaterial;
        var tex = mat.mainTexture;
        return tex;
    }

    public static Texture GetDefaultNormal()
    {
        var mat = Instance.defaultPrefab.GetComponent<MeshRenderer>().sharedMaterial;
        mat.EnableKeyword("_NORMALMAP");
        var tex = mat.GetTexture("_BumpMap");
        return tex;
    }

    public static Mesh GetDefaultGlyphMesh()
    {
        var mesh = Instance.defaultPrefab.GetComponent<MeshFilter>().sharedMesh;
        return mesh;
    }


    public string libraryPath;

    public string dataPath;

    void Start() {
        dataPath = Path.Combine(Application.persistentDataPath, "media", "visassets");
        Directory.CreateDirectory(dataPath);
        LoadLibrary();
    }

    public List<JSONObject> GetLocalPaletteMetadata()
    {
        string[] files = Directory.GetFiles(Path.Combine(dataPath, libraryPath), VISASSET_JSON, SearchOption.AllDirectories);
        List<JSONObject> metadata = new List<JSONObject>();

        foreach (var file in files)
        {
            var jsonData = GetArtifactMetadata(file);
            if (jsonData != null)
            {
                metadata.Add(jsonData);
            }
        }
        return metadata;
    }

    public JSONObject GetArtifactMetadata(string file)
    {
        StreamReader reader = new StreamReader(file);
        JSONObject jsonData = JSONObject.Create(reader.ReadToEnd());
        reader.Close();
        if (!jsonData.HasField("uuid")) return null;
        string uuid = jsonData["uuid"].str;
        if (uuid != Path.GetDirectoryName(file).Split(Path.DirectorySeparatorChar).Last())
        {
            Debug.LogError("uuid in artifact.json does not match folder name: " + uuid + ", " + Path.GetDirectoryName(file).Split(Path.DirectorySeparatorChar).Last());
            return null;
        }

        return jsonData;
    }

    string ArtifactDataPath(string artifactFilePath, string relativeDataPath)
    {
        return Path.Combine(Path.GetDirectoryName(artifactFilePath), relativeDataPath);
    }

    void GetAllStringValuesFromJson(JSONObject json, List<string> strings)
    {
        if(json.IsString)
        {
            strings.Add(json.str);
        }else if(json.IsObject)
        {
            foreach(var j in json.keys)
            {
                GetAllStringValuesFromJson(json[j], strings);
            }
        }
        else if (json.IsArray)
        {
            foreach (var j in json.list)
            {
                GetAllStringValuesFromJson(j, strings);
            }
        }
    }
    public void DownloadVisAsset(string uuid, bool runSync = false)
    {
        var task = Task.Run(async () =>
       {

           string artifactPath =  await DownloadFile(Path.Combine(uuid, VISASSET_JSON));
           string thumbnailPath = await DownloadFile(Path.Combine(uuid, "thumbnail.png"));

           StreamReader reader = new StreamReader(artifactPath);
           JSONObject jsonData = JSONObject.Create(reader.ReadToEnd());
           reader.Close();
           List<string> strings = new List<string>();
           GetAllStringValuesFromJson(jsonData["artifactData"], strings);

           List<Task> downloadtasks = new List<Task>();
           strings.Reverse();
           foreach(var path in strings)
           {           
               downloadtasks.Add(DownloadFile(Path.Combine(uuid, path)));
           }

          await Task.WhenAll(downloadtasks);

           mainThreadActions.Enqueue(() =>
           {
               Debug.Log("Loading in an artifact ");
               LoadVisasset(artifactPath);
               ABRManager.Instance.MarkStateChanged();

           });

           
           

       });
        if (runSync == true) task.Wait();
    }
    Queue<Action> mainThreadActions = new Queue<Action>();
    WebClient _client;
    object downloadLock = new object();

    string webpage = "http://sculptingvis.tacc.utexas.edu/static/Artifacts";
    async Task<string> DownloadFile(string file)
    {

        var _url = Path.Combine("http://sculptingvis.tacc.utexas.edu/static/Artifacts", file);
        var _destinationPath = Path.Combine(dataPath, libraryPath, file);

        Debug.Log("Downloading " + _destinationPath);
        if(_client == null) _client = new WebClient();
        //_client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_client_DownloadProgressChanged);
        Directory.CreateDirectory(Path.GetDirectoryName(_destinationPath));
        try
        {
            lock(downloadLock)
            {
                _client.DownloadFile(new Uri(_url), _destinationPath); //Download the file. 

            }

        } catch(Exception e)
        {
            Debug.LogError(e);
        }
        Debug.Log("Downloaded " + _destinationPath);
        return _destinationPath;
        
    }

    public void LoadVisasset(Guid visAssetUUID)
    {
        var visassetPath = Path.Combine(
            dataPath,
            libraryPath,
            visAssetUUID.ToString(),
            VISASSET_JSON
        );
        LoadVisasset(visassetPath);
    }

    public void LoadVisasset(string filePath, bool replaceExisting=false)
    {
        Debug.Log(filePath);
        StreamReader reader = new StreamReader(filePath);
        JSONObject jsonData = JSONObject.Create(reader.ReadToEnd());
        reader.Close();
        string type = "";
        if (jsonData.HasField("artifactType"))
        {
            type = jsonData["artifactType"].str;
        }
        else if (jsonData.HasField("type"))
        {
            type = jsonData["type"].str;
        }

        GameObject visAssetObject = new GameObject(type + " " + jsonData["name"]);
        visAssetObject.transform.SetParent(transform);

        if (type == "colormap")
        {
            var guid = new System.Guid(jsonData["uuid"].str);
            TextureColormapVisAsset visAsset;
            if (!replaceExisting)
            {
                visAsset = ABRManager.CreateNode<TextureColormapVisAsset>(guid);
            }
            else
            {
                visAsset = ABRManager.Instance.registeredNodes[guid] as TextureColormapVisAsset;
            }
            ABRManager.Instance.SetNodeLabel(visAsset, jsonData["name"]?.str ?? "");


            try
            {
                string relativeColormapPath = "colormap.xml";//jsonData["artifactData"]["image"].str;

                string colormapfilePath = Path.Combine(Path.GetDirectoryName(filePath), relativeColormapPath);
                Texture2D texture = null;
                byte[] fileData;

                if (File.Exists(colormapfilePath)) // ERROR: The name 'File' does not exist in the current context?
                {
                    texture = ColormapUtilities.ColormapFromFile(colormapfilePath);
                    visAsset.Gradient = texture;
                }
                visAsset.ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.Unknown });

            }
            catch (System.Exception e) { 
                Debug.LogError("VisAsset not suppported yet: " + type + " (" + jsonData["uuid"].str + ")");
                Debug.LogError(e);
            }

        }


        if (type == "glyph")
        {
            GlyphVisAsset visAsset = ABRManager.CreateNode<GlyphVisAsset>(new System.Guid(jsonData["uuid"].str));
            ABRManager.Instance.SetNodeLabel(visAsset, jsonData["name"]?.str ?? "");

            var artifactData = jsonData["artifactData"];
            try
            {
                JSONObject lodsList = null;

                if (artifactData.HasField("lods"))
                {
                    lodsList = artifactData.GetField("lods");

                } else if(artifactData.IsArray)
                {
                    lodsList = artifactData;
                }

                if (lodsList != null)
                {

                    foreach (var lodJson in lodsList.list)
                    {
                        var meshPath = ArtifactDataPath(filePath, lodJson["mesh"].str);
                        var normalPath = ArtifactDataPath(filePath, lodJson["normal"].str);
                        Debug.Log("Loading mesh: " + meshPath);
                        GameObject loadedObjGameObject = null;
                        try
                        {
                            loadedObjGameObject = new OBJLoader().Load(meshPath);
                        }
                        catch (System.Exception e)
                        {
                            Debug.Log(e);
                        }
                        Debug.Log(loadedObjGameObject);
                        loadedObjGameObject.transform.SetParent(transform);
                        loadedObjGameObject.SetActive(false);
                        var loadedMesh = loadedObjGameObject.GetComponentInChildren<MeshFilter>().mesh;
                        Debug.Log(loadedMesh);
                        GameObject.Destroy(loadedObjGameObject);

                        var normalData = File.ReadAllBytes(normalPath); // ERROR: The name 'File' does not exist in the current context?
                        var normalMap = new Texture2D(2, 2);
                        normalMap.LoadImage(normalData);


                        visAsset.MeshLods.Add(loadedMesh);
                        visAsset.NormalMapLods.Add(normalMap);

                    }
                }
                else
                {
                    throw (new System.Exception());
                }

                visAsset.ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.Unknown });

            }
            catch (System.Exception e) { Debug.Log("VisAsset not suppported yet: " + type + " (" + jsonData["uuid"].str + ")"); }
        }
        if (type == "line")
        {
            LineTextureVisAsset visAsset = ABRManager.CreateNode<LineTextureVisAsset>(new System.Guid(jsonData["uuid"].str));
            ABRManager.Instance.SetNodeLabel(visAsset, jsonData["name"]?.str ?? "");

            var artifactData = jsonData["artifactData"];
            try
            {
                if (artifactData.HasField("horizontal"))
                {
                    var texturePath = ArtifactDataPath(filePath, artifactData["horizontal"].str);

                    var textureData = File.ReadAllBytes(texturePath); // ERROR: The name 'File' does not exist in the current context?
                    var texture = new Texture2D(2, 2);
                    texture.LoadImage(textureData);

                    visAsset.TextureArray = new Texture2D[] { texture };
                }
                else
                {
                    throw (new System.Exception());
                }
            }
            catch (System.Exception e) { Debug.Log("VisAsset not suppported yet: " + type + " (" + jsonData["uuid"].str + ")"); }
        }


        if (type == "texture")
        {
            SurfaceTextureVisAsset visAsset = ABRManager.CreateNode<SurfaceTextureVisAsset>(new System.Guid(jsonData["uuid"].str));
            ABRManager.Instance.SetNodeLabel(visAsset, jsonData["name"]?.str ?? "");

            var artifactData = jsonData["artifactData"];
            try
            {
                if (artifactData.HasField("image"))
                {
                    var texturePath = ArtifactDataPath(filePath, artifactData["image"].str);

                    var textureData = File.ReadAllBytes(texturePath); // ERROR: The name 'File' does not exist in the current context?
                    var texture = new Texture2D(2, 2);
                    texture.LoadImage(textureData);

                    visAsset.TextureArray = new Texture2D[] { texture };


                    var normalPath = ArtifactDataPath(filePath, artifactData["normalmap"].str);

                    var normalData = File.ReadAllBytes(normalPath); // ERROR: The name 'File' does not exist in the current context?
                    var normal = new Texture2D(2, 2);
                    normal.LoadImage(normalData);

                    visAsset.NormalMapArray = new Texture2D[] { normal };
                }
                else
                {
                    throw (new System.Exception());
                }
            }
            catch (System.Exception e) { Debug.Log("VisAsset not suppported yet: " + jsonData["name"]?.str ?? "Untitled" + " (" + jsonData["uuid"].str + ")"); }
        }
    }
    public void LoadLibrary()
    {
        string[] files = Directory.GetFiles(Path.Combine(dataPath, libraryPath), VISASSET_JSON, SearchOption.AllDirectories);

        foreach (var filePath in files)
        {
            LoadVisasset(filePath);
        }
    }

    public void ReloadVisAsset(string uuid)
    {
        var guid = new Guid(uuid);
        // ABRManager.Instance.DestroyNode(guid);
        string visAssetPath = Path.Combine(dataPath, libraryPath, uuid, VISASSET_JSON);
        LoadVisasset(visAssetPath, true);
        ABRManager.Instance.MarkStateChanged();
    }

    // Load a VisAsset that's been saved in the json state
    //
    // Currently only valid for lightweight VisAssets like Colormaps
    //
    // Must have all the fields of the `artifact.json` file originally saved
    // with this VisAsset, in addition to the `contents` field which represents
    // the contents of the VisAsset. In this case, 'colormap.xml' as a string.
    // Should also have the field `stateSpecific: true` which signifies that
    // this VisAsset was saved with a specific state.
    public void LoadVisassetFromJson(JSONObject stateVisAsset)
    {
        var type = stateVisAsset.GetField("type").str;
        if (type != "colormap")
        {
            throw new Exception("Only colormaps can be loaded from a state");
        }
        if (!stateVisAsset.GetField("stateSpecific"))
        {
            throw new Exception("Can only load state-specific VisAssets with state");
        }
        var uuid = new Guid(stateVisAsset.GetField("uuid").str);

        // Save the contents externally so we can write it and the
        // `artifact.json` file
        var contents = stateVisAsset.GetField("contents");
        stateVisAsset.RemoveField("contents");

        // Write the `artifact.json` and `colormap.xml`
        var visassetPath = Path.Combine(dataPath, libraryPath, uuid.ToString());
        var artifactJsonPath = Path.Combine(visassetPath, VISASSET_JSON);
        var colormapPath = Path.Combine(visassetPath, "colormap.xml");

        Directory.CreateDirectory(visassetPath);
        using (StreamWriter sw = new StreamWriter(artifactJsonPath))
        {
            sw.Write(stateVisAsset.ToString());
        }
        using (StreamWriter sw = new StreamWriter(colormapPath))
        {
            sw.Write(contents.str.Replace("\\\"", "\""));
        }

        // Generate the thumbnail using default size from the library
        var texture = ColormapUtilities.ColormapFromFile(colormapPath, 200, 30);
        ColormapUtilities.SaveTextureAsPng(
            Path.Combine(visassetPath, "thumbnail.png"),
            texture
        );

        mainThreadActions.Enqueue(() =>
        {
            Debug.Log("Loading in an artifact from json");
            LoadVisasset(artifactJsonPath);
            ABRManager.Instance.MarkStateChanged();
        });
    }

    public bool loadLibrary = false;
    // Update is called once per frame
    public string fileToDownload = "";
    public bool download = false;

    void Update()
    {
        while(mainThreadActions.Count> 0)
        {
            mainThreadActions.Dequeue()?.Invoke();
        }
        if(download)
        {
            download = false;
            Task.Run(() =>
            {
                DownloadVisAsset(fileToDownload);

            });
        }
        //if(loadLibrary)
        //{
        //    loadLibrary = false;
        //    LoadLibrary();
        //}

    }
}
