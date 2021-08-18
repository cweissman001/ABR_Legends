using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class TestMesseger : MonoBehaviour
{

    Dictionary<EncodingRenderStrategy, ABREncoding> perStrategyEncodings = new Dictionary<EncodingRenderStrategy, ABREncoding>();

    EncodingSet mainEncodingSet;
    ABRDataScene mainDataScene;

    public
    Transform dataSceneRoot;

    Queue<System.Action> mainThreadActions = new Queue<System.Action>();

    Dictionary<ABRNode, JSONObject> perNodeUIData = new Dictionary<ABRNode, JSONObject>();

    VisAssetManager assetManager;

    List<JSONObject> lightCache = new List<JSONObject>();

    string persistentDataPath;

    string currentStateName = "Untitled";

    public Camera captureCamera;
    private int frameCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        assetManager = GetComponent<VisAssetManager>();
        ABRMessenger.Instance.OnAbrMessage += ReceiveAbrMessage;
        ABRManager.Instance.OnStateChangedEvent += OnABRStateChanged;

        mainEncodingSet = ABRManager.CreateNode<EncodingSet>();
        mainDataScene = ABRManager.CreateNode<ABRDataScene>();
        
        mainDataScene.AssignInput("Encoding Set",mainEncodingSet);

        persistentDataPath = Path.Combine(Application.persistentDataPath, "media");

        SaveState(this.currentStateName, "", true);
        InvokeRepeating("AutoSave", 1f, 1f);  //1s delay, repeat every 1s

        UpdateLightCache();
    }
    bool needsAutosave = false;
    void AutoSave()
    {
        
        mainThreadActions.Enqueue(() => {
            if(needsAutosave)
            SaveState("AutoSave", System.IO.Path.Combine(persistentDataPath, "states"), false, updateUI:false, isScreenshot:false);
            needsAutosave = false;
        });
    }

    static BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public;

    static Dictionary<string, string> topologyMap = new Dictionary<string, string>()
    {
        {"","Unknown" },
        {"Triangles","Surface" },
        {"Quads", "Surface" },
        {"Points","Point" },
        {"Lines","Line" },
        {"LineStrip","Line" }

    };


    public JSONObject GenerateUIState()
    {
        JSONObject stateJson = JSONObject.Create(JSONObject.Type.OBJECT);
        stateJson.AddField("currentStateName", this.currentStateName);

        // HEADER
        // Strategies
        JSONObject headerJson = JSONObject.Create(JSONObject.Type.OBJECT);

        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        var stategyBaseType = typeof(EncodingRenderStrategy);
        var strategyTypes = assembly.GetTypes().Where(
            t => stategyBaseType.IsAssignableFrom(t) && t != stategyBaseType);
        JSONObject strategiesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        foreach (var strategyType in strategyTypes)
        {
            JSONObject strategyJson = JSONObject.Create(JSONObject.Type.OBJECT);
            strategyJson.AddField("name", strategyType.GetCustomAttribute<EncodingStrategyAttribute>().StrategyName);
            strategyJson.AddField("type", strategyType.FullName);

            strategyJson.AddField("topology", strategyType.GetCustomAttribute<EncodingStrategyAttribute>().TopologyType.ToString());


            JSONObject strategyInputsJson = JSONObject.Create(JSONObject.Type.ARRAY);

            var inputs = strategyType.GetFields(bindingFlags)
                .Where(f => f.GetCustomAttribute<ABRInputAttribute>() != null);

            foreach (var inputField in inputs)
            {
                JSONObject inputData = JSONObject.Create(JSONObject.Type.OBJECT);
                inputData.AddField("parameterName", inputField.GetCustomAttribute<ABRInputAttribute>().parameterName);
                inputData.AddField("inputName", inputField.GetCustomAttribute<ABRInputAttribute>().inputName);
                inputData.AddField("inputType", inputField.FieldType.FullName);
                inputData.AddField("defaultText", inputField.GetCustomAttribute<ABRInputAttribute>().defaultText);

                inputData.AddField("tooltipText", inputField.GetCustomAttribute<ABRInputAttribute>().tooltipText);
                inputData.AddField("advancedOnly", inputField.GetCustomAttribute<ABRInputAttribute>().advancedOnly);


                strategyInputsJson.Add(inputData);
            }
            strategyJson.AddField("inputs", strategyInputsJson);


            strategiesJson.Add(strategyJson);
        }
        headerJson.AddField("renderingStrategies", strategiesJson);

        // Data
        JSONObject dataJson = JSONObject.Create(JSONObject.Type.OBJECT);

        // KeyData

        JSONObject keyDataJson = JSONObject.Create(JSONObject.Type.ARRAY);

        var dataObjects = ABRManager.Instance.registeredNodes.Values.Where(n => n is DataObject).Select(n => n as DataObject);
        foreach (var dataobject in dataObjects)
        {
            JSONObject dataObjectJson = JSONObject.Create(JSONObject.Type.OBJECT);
            dataObjectJson.AddField("label", ABRManager.Instance.GetNodeLabel(dataobject));
            dataObjectJson.AddField("uuid", dataobject.UniqueID.ToString());

            string dataType = topologyMap[dataobject.dataset?.meshTopology.ToString() ?? ""];
            dataObjectJson.AddField("topology", dataType);


            JSONObject objectScalarVariablesJson = JSONObject.Create(JSONObject.Type.ARRAY);
            var objectScalarVariables = dataobject?.dataset?.scalarArrayNames;
            if (objectScalarVariables != null)
                foreach (var v in objectScalarVariables)
                {
                    objectScalarVariablesJson.Add(v);
                }

            JSONObject objectVectorVariablesJson = JSONObject.Create(JSONObject.Type.ARRAY);
            var objectVectorVariables = dataobject?.dataset?.vectorArrayNames;
            if (objectVectorVariables != null)
                foreach (var v in objectVectorVariables)
                {
                    objectVectorVariablesJson.Add(v);
                }
            dataObjectJson.AddField("scalarVariables", objectScalarVariablesJson);
            dataObjectJson.AddField("vectorVariables", objectVectorVariablesJson);



            keyDataJson.Add(dataObjectJson);
        }
        dataJson.AddField("keyData", keyDataJson);

        // Variables
        JSONObject scalarVariablesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        var scalars = ABRManager.Instance.registeredNodes.Values.Where(n => n is RawScalarDataVariable).Select(n => n as RawScalarDataVariable);
        foreach (var scalar in scalars)
        {
            JSONObject scalarJson = JSONObject.Create(JSONObject.Type.OBJECT);
            scalarJson.AddField("label", ABRManager.Instance.GetNodeLabel(scalar));
            scalarJson.AddField("uuid", scalar.UniqueID.ToString());
            scalarJson.AddField("minValue", scalar.GetScalarMin());
            scalarJson.AddField("maxValue", scalar.GetScalarMax());



            scalarVariablesJson.Add(scalarJson);
        }
        dataJson.AddField("scalarVariables", scalarVariablesJson);



        JSONObject vectorVariablesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        var vectors = ABRManager.Instance.registeredNodes.Values.Where(n => n is RawVectorDataVariable).Select(n => n as RawVectorDataVariable);
        foreach (var vector in vectors)
        {
            JSONObject vectorJson = JSONObject.Create(JSONObject.Type.OBJECT);
            vectorJson.AddField("label", ABRManager.Instance.GetNodeLabel(vector));
            vectorJson.AddField("uuid", vector.UniqueID.ToString());

            vectorVariablesJson.Add(vectorJson);
        }
        dataJson.AddField("vectorVariables", vectorVariablesJson);






        headerJson.AddField("availableData", dataJson);


        var varBaseType = typeof(IUIVariableInput);
        var artifactBaseType = typeof(IUIVisAssetInput);
        var varTypes = assembly.GetTypes().Where(
            t => varBaseType.IsAssignableFrom(t) && t != varBaseType);
        var artifactTypes = assembly.GetTypes().Where(
            t => artifactBaseType.IsAssignableFrom(t) && t != artifactBaseType);
        JSONObject varTypesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        JSONObject artifactTypesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        foreach (var varType in varTypes)
        {
            varTypesJson.Add(varType.ToString());
        }
        foreach (var artifactType in artifactTypes)
        {
            artifactTypesJson.Add(artifactType.ToString());
        }
        headerJson.AddField("variableTypes", varTypesJson);
        headerJson.AddField("artifactTypes", artifactTypesJson);

        // Find out the lights that are saveable by the scene (from the cache
        // because we can't get light info while not in main thread)
        var lightList = JSONObject.Create(JSONObject.Type.ARRAY);
        lightList.list = lightCache;
        headerJson.AddField("lights", lightList);

        // Numeric inputs available (and their uuids)
        JSONObject numericInputsJson = JSONObject.Create(JSONObject.Type.ARRAY);
        var numericInputs = ABRManager.Instance.registeredNodes.Values.Where(n => n is RealNumber).Select(n => n as RealNumber);
        foreach (var input in numericInputs)
        {
            JSONObject inputJson = ABRNode.Serialize(input);
            numericInputsJson.Add(inputJson);
        }

        stateJson.AddField("numericInputs", numericInputsJson);

        // Checkbox inputs available (and their uuids)
        JSONObject checkboxInputsJson = JSONObject.Create(JSONObject.Type.ARRAY);
        var checkboxInputs = ABRManager.Instance.registeredNodes.Values.Where(n => n is Checkbox).Select(n => n as Checkbox);
        foreach (var input in checkboxInputs)
        {
            JSONObject inputJson = ABRNode.Serialize(input);
            checkboxInputsJson.Add(inputJson);
        }

        stateJson.AddField("checkboxInputs", checkboxInputsJson);

        // Numeric inputs available (and their uuids)
        JSONObject rangedScalarsJson = JSONObject.Create(JSONObject.Type.ARRAY);
        var rangedScalars = ABRManager.Instance.registeredNodes.Values.Where(n => n is RangedScalarDataVariable).Select(n => n as RangedScalarDataVariable);
        foreach (var input in rangedScalars)
        {
            JSONObject inputJson = ABRNode.Serialize(input);
            rangedScalarsJson.Add(inputJson);
        }

        stateJson.AddField("rangedScalars", rangedScalarsJson);


        stateJson.AddField("header", headerJson);

        // Other nodes
        JSONObject nodeList = JSONObject.Create(JSONObject.Type.ARRAY);
        foreach (var node in ABRManager.Instance.registeredNodes.Values)
        {
            if (typeof(RawDataVariable).IsAssignableFrom(node.GetType()))
            {

            } 
            else if(typeof(EncodingRenderStrategy).IsAssignableFrom(node.GetType()))
            {
                JSONObject strategyObjectJson = JSONObject.Create(JSONObject.Type.OBJECT);
                strategyObjectJson.AddField("type", node.GetType().FullName);
                strategyObjectJson.AddField("uuid", node.UniqueID.ToString());
                strategyObjectJson.AddField("label", ABRManager.Instance.GetNodeLabel(node));

                ABREncoding encoding;


                if(perStrategyEncodings.TryGetValue(node as EncodingRenderStrategy,out encoding))
                //if ()
                {
                    if(encoding.GetInputValue("Data Object") == null)
                    {
                        strategyObjectJson.AddField("keydataUUID", JSONObject.nullJO);

                    } else
                    {
                        strategyObjectJson.AddField("keydataUUID", encoding.GetInputValue("Data Object")?.UniqueID.ToString());

                    }
                } else
                {
                    strategyObjectJson.AddField("keydataUUID", JSONObject.nullJO);
                }

                JSONObject connectionsJson = JSONObject.Create(JSONObject.Type.OBJECT);

                for (int i = 0; i < (node as ABRObject).InputCount; i++)
                {
                    string name = (node as ABRObject).GetInputName(i);
                    if((node as ABRObject).GetInputValue(i) == null)
                    {
                        connectionsJson.AddField(name, JSONObject.nullJO);

                    } else
                    {
                        connectionsJson.AddField(name, (node as ABRObject).GetInputValue(i)?.UniqueID.ToString() ?? "");

                    }
                }
                strategyObjectJson.AddField("connections", connectionsJson);

                strategyObjectJson.AddField("uiMetadata", perNodeUIData.ContainsKey(node) ? perNodeUIData[node] : JSONObject.nullJO);



                nodeList.Add(strategyObjectJson);



            }
            else
            {

            }



        }


        JSONObject availableVisassetsJson = JSONObject.Create(JSONObject.Type.ARRAY);

        var artifactJsons = assetManager.GetLocalPaletteMetadata();
        foreach (var artifactJson in artifactJsons)
        {
            JSONObject visassetJson = JSONObject.Create(JSONObject.Type.OBJECT);
            visassetJson.AddField("uuid", artifactJson["uuid"].str);
            string type = ((artifactJson["artifactType"]?.str ?? artifactJson["type"]?.str) ?? "");

            visassetJson.AddField("name", artifactJson["name"]?.str ?? "(Untitled) " + artifactJson["family"].str + "/" + artifactJson["class"].str + " " + type);
            if (type == "glyph")
            {
                visassetJson.AddField("artifactType", nameof(IGlyph));
            } 
            else if (type == "colormap")
            {
                visassetJson.AddField("artifactType", nameof(IColormap));
            } 
            else if(type == "texture")
            {
                visassetJson.AddField("artifactType", nameof(ISurfaceTexture));

            }
            else if (type == "line")
            {
                visassetJson.AddField("artifactType", nameof(ILineTexture));

            }
            else
            {
                visassetJson.AddField("artifactType", JSONObject.nullJO);
            }

            availableVisassetsJson.Add(visassetJson);
        }

        stateJson.AddField("availableVisassets", availableVisassetsJson);

        JSONObject availableStatesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        var stateNames = GetStates();
        foreach(var stateName in stateNames)
        {
            availableStatesJson.Add(stateName);
        }
        stateJson.AddField("availableStates",availableStatesJson);

        stateJson.AddField("compositionNodes", nodeList);
        return stateJson;
    }

    bool shouldSendStateChange = false;


    // Suuuuuuper hacky. Avoid over-writing the autosave on basic start-up. 3 IS A MAGIC NUMBER!
    int timesToWaitUntilAutosave = 3;
    int timesTriedtoAutosave = 0;

    bool autosaveOn = false;
    bool autosavePaused = false;
    void OnABRStateChanged()
    {
        shouldSendStateChange = true;
        if(timesToWaitUntilAutosave < timesTriedtoAutosave)
        {

            autosaveOn = true;

        }
        timesTriedtoAutosave++;

        if (autosaveOn && !autosavePaused)
            needsAutosave = true;


    }


   


    void ReceiveAbrMessage(AbrMessage message)
    {

        typeof(object).IsAssignableFrom(typeof(string));
        string s = "";
        object myVar = s;

        switch (message.type)
        {
            case AbrMessageType.StateRequest:
                SendStateUpdate();
                break;
            case AbrMessageType.Update:
                HandleUpdate(JSONObject.Create(message.message));
                break;
            case AbrMessageType.ReloadVisAsset:
                // Reload the palette if something has changed
                mainThreadActions.Enqueue(() => {
                    VisAssetManager.Instance.ReloadVisAsset(message.message);
                    SendStateUpdate();
                });
                break;
            case AbrMessageType.CreateStateVisAsset:
                // Load a state-specific VisAsset that was created by the colormap editor
                mainThreadActions.Enqueue(() => {
                    VisAssetManager.Instance.LoadVisasset(new Guid(message.message));
                    SendStateUpdate();
                });
                break;
            case AbrMessageType.LegendViewRequest:
                SendLegendView(JSONObject.Create(message.message));
                break;
            default:
                break;
        }
    }

    public void HandleUpdate(JSONObject json)
    {
        var updateType = json.GetField("type")?.str ?? "";



        if (updateType == "DeleteState")
        {
            var stateName = json.GetField("stateName")?.str ?? "";
            var statePath = System.IO.Path.Combine(persistentDataPath, "states", stateName + ".json");
            var screenshotFolderPath = System.IO.Path.Combine(persistentDataPath, "screenshots", stateName );
            var thumbnailPath = System.IO.Path.Combine(persistentDataPath, "states", stateName + "#thumbnail.png");

            var trashstatePath = System.IO.Path.Combine(persistentDataPath, "state_trash", stateName + ".json");
            var trashscreenshotFolderPath = System.IO.Path.Combine(persistentDataPath, "screenshot_trash", stateName);
            var trashthumbnailPath = System.IO.Path.Combine(persistentDataPath, "state_trash", stateName + "#thumbnail.png");

            Directory.CreateDirectory(trashscreenshotFolderPath);
            Directory.CreateDirectory(System.IO.Path.Combine(persistentDataPath, "state_trash"));
            File.Delete(trashstatePath);
            File.Delete(trashthumbnailPath);

            if (File.Exists(statePath))
                File.Move(statePath, trashstatePath);

            if (File.Exists(thumbnailPath))
                File.Move(thumbnailPath, trashthumbnailPath);

            if(Directory.Exists(screenshotFolderPath))
            {
                List<String> screenshotFiles = Directory
                   .GetFiles(screenshotFolderPath, "*.*", SearchOption.AllDirectories).ToList();

                foreach (string file in screenshotFiles)
                {
                    var destPath = System.IO.Path.Combine(persistentDataPath, "screenshot_trash", stateName, Path.GetFileName(file));

                    if (File.Exists(destPath)) File.Delete(destPath);
                    File.Move(file, destPath);                    
                }

                Directory.Delete(screenshotFolderPath);

            }

            ABRManager.Instance.MarkStateChanged();
            this.currentStateName = "Untitled";
        }

        if (updateType == "DownloadArtifact")
        {
            var uuid = json.GetField("uuid")?.str ?? "";
            if (uuid != "") ;
                VisAssetManager.Instance.DownloadVisAsset(uuid);

        }

        else if (updateType == "UploadState")
        {
            JSONObject stateContentsJson = json.GetField("stateContents");
            string stateName = json.GetField("stateName")?.str ?? "state";

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(System.IO.Path.Combine(persistentDataPath, "states", stateName + ".json")))
            {
                file.Write(stateContentsJson.ToString(true));
                Debug.Log("Wrote new state file " + stateName);
            }

            SendStateUpdate();
        }
        else if (updateType == "DeleteNode")
        {
            var uuidJson = json.GetField("uuid") ?? null;
            if (uuidJson == null) {
                return;
            }
            var deleteVisAsset = json.GetField("deleteVisAsset")?.b ?? false;
            var guid = new Guid(uuidJson.str);

            var deletedVisAsset = false;
            if (deleteVisAsset) {
                try {
                    var visAssetPath = System.IO.Path.Combine(persistentDataPath, "visassets", uuidJson.str);
                    Debug.Log("Deleting VisAsset from disk " + visAssetPath);
                    System.IO.Directory.Delete(visAssetPath, true);
                    deletedVisAsset = true;
                } catch (System.IO.IOException e) {
                    Debug.Log("Unable to delete VisAsset. Try again.");
                }
            }

            if(ABRManager.Instance.registeredNodes.ContainsKey(guid))
            {
                // Only remove node if actually deleted on disk
                if (!deleteVisAsset || (deleteVisAsset && deletedVisAsset)) {
                    ABRNode node = ABRManager.Instance.registeredNodes[guid];
                    if (node is EncodingRenderStrategy && perStrategyEncodings.ContainsKey(node as EncodingRenderStrategy))
                    {
                        ABRManager.Instance.DestroyNode(perStrategyEncodings[ABRManager.Instance.registeredNodes[guid] as EncodingRenderStrategy].UniqueID);

                    }

                    ABRManager.Instance.DestroyNode(guid);
                }
            } else
            {
                Debug.Log("Guid does not exist: " + guid);
            }




        }
        else if (updateType == "UpdateRenderStrategy")
        {
            var objectJson = json.GetField("object") ?? null;
            if(objectJson != null)
            {
                Guid uuid;
                try
                {
                    uuid = new System.Guid(objectJson.GetField("uuid")?.str ?? "");
                }
                catch (FormatException e)
                {
                    Debug.LogError(e);
                    return;
                }
                var objectType = System.Type.GetType(objectJson.GetField("type")?.str ?? "");
                var label = objectJson.GetField("label")?.str ?? "";

                var connectionsJson = objectJson.GetField("connections");
                mainThreadActions.Enqueue(() =>
                {
                    ABRNode node;
                    if (ABRManager.Instance.registeredNodes.TryGetValue(uuid, out node) == false)
                    {
                        ABREncoding encoding = ABRManager.CreateNode<ABREncoding>();
                        node = ABRManager.CreateNode(objectType, uuid);
                        encoding.AssignInput("Rendering Strategy", node);
                        mainEncodingSet = (EncodingSet)ABRManager.Instance.registeredNodes.Values.Where(a => a.GetType() == typeof(EncodingSet)).FirstOrDefault();
                        mainEncodingSet.Add(encoding);
                        perStrategyEncodings.Add(node as EncodingRenderStrategy, encoding);

                    }
                    ABRManager.Instance.SetNodeLabel(node, label);

                    perNodeUIData[node] = objectJson.GetField("uiMetadata");
                    ABRManager.Instance.GetUICacheJson().SetField(node.UniqueID.ToString(), perNodeUIData[node]);

                    // Find out whether the RS is hidden
                    var hidden = perNodeUIData[node].GetField("hidden")?.b ?? false;
                    (node as EncodingRenderStrategy).Hidden = hidden;

                    if ( ! objectJson.GetField("keydataUUID")?.IsNull ?? false)
                    {
                        var keyDataUuid = new System.Guid(objectJson.GetField("keydataUUID")?.str ?? "");
                        ABRNode keyData;
                        if (ABRManager.Instance.registeredNodes.TryGetValue(keyDataUuid, out keyData))
                        {

                            var encoding = perStrategyEncodings[node as EncodingRenderStrategy];
                            encoding.AssignInput("Data Object", (keyData as IDataObject));
                        }
                    }
                    else
                    {

                        var encoding = perStrategyEncodings[node as EncodingRenderStrategy];
                        encoding.AssignInput("Data Object", null);
                    }

                    foreach(var connectionKey in connectionsJson.keys)
                    {
                        if (connectionsJson[connectionKey].IsNull)
                        {
                            (node as ABRObject).AssignInput(connectionKey, null);

                        }
                        else
                        {
                            Guid guid = new Guid(connectionsJson[connectionKey].str);
                            ABRNode inputAssignment;
                            if (ABRManager.Instance.registeredNodes.TryGetValue(guid, out inputAssignment))
                            {
                                Debug.Log(inputAssignment.GetType().Name + " node " + inputAssignment.UniqueID + " assigned to " + connectionKey + " of " + node.GetType() + " node " + node.UniqueID);
                                (node as ABRObject).AssignInput(connectionKey, inputAssignment);
                            }
                        }

                    }

                

                });

            }

        }
        else if (updateType == "UpdateNode")
        {
            var objectJson = json.GetField("object") ?? null;
            if(objectJson != null)
            {
                var uuid = new System.Guid(objectJson.GetField("uuid")?.str ?? "");
                mainThreadActions.Enqueue(() =>
                {
                    ABRNode node = null;
                    if (!ABRManager.Instance.registeredNodes.TryGetValue(uuid, out node))
                    {
                        node = null;
                    }

                    node = ABRNode.Deserialize(objectJson, node);
                });
            }
            ABRManager.Instance.MarkStateChanged();
        }
        else if (updateType == "LoadState")
        {
            var stateName = json.GetField("stateName")?.str;
            mainThreadActions.Enqueue(() => {
                LoadState(stateName);
                UpdateLightCache();
            });
        }
        else if (updateType == "SaveState")
        {
            var stateName = json.GetField("stateName")?.str;
            mainThreadActions.Enqueue(() => {
                SaveState(stateName, System.IO.Path.Combine(persistentDataPath, "states"), true, isScreenshot:false);


            });
        }

        else if (updateType == "SaveScreenshot")
        {
            var stateName = json.GetField("stateName")?.str;
            mainThreadActions.Enqueue(() => {
                SaveState(stateName + "#" + string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now), System.IO.Path.Combine(persistentDataPath, "screenshots",stateName), isScreenshot:true);
            });
        }

        else if (updateType == "UpdateLights")
        {
            var lightList = json.GetField("lightList")?.list ?? new List<JSONObject>();
            mainThreadActions.Enqueue(() => {
                for (int i = 0; i < lightList.Count; i++)
                {
                    var intensity = lightList[i].GetField("intensity")?.f ?? 0.0f;
                    var directionX = lightList[i].GetField("directionX")?.f ?? 0.0f;
                    var directionY = lightList[i].GetField("directionY")?.f ?? 0.0f;
                    var directionZ = lightList[i].GetField("directionZ")?.f ?? 0.0f;
                    lightCache[i] = lightList[i];
                    ABRManager.Instance.lightsToSave[i].intensity = intensity;
                    ABRManager.Instance.lightsToSave[i].transform.rotation = Quaternion.Euler(directionX, directionY, directionZ);
                }
            });
            SendStateUpdate();
        }

        else if (updateType == "ClearState")
        {
            this.currentStateName = "Untitled";
            mainThreadActions.Enqueue(() => {
                ABRManager.Instance.ClearState();
                SendStateUpdate();
            });
        }


    }

    public void SendStateUpdate()
    {

        JSONObject jsonState = GenerateUIState();

        foreach(var nodeData in jsonState.GetField("compositionNodes").list)
        {
            var uuid = new System.Guid(nodeData["uuid"].str);
            JSONObject nodeUIData = null;
            if(perNodeUIData.TryGetValue(ABRManager.Instance.registeredNodes[uuid], out nodeUIData))
            {
                nodeData.AddField("uiMetadata", nodeUIData);
            }


        }
        details = jsonState.ToString(true);

        ABRMessenger.Instance.SendAbrMessage(new AbrMessage(AbrMessageType.State, jsonState.ToString(false)));
    }

    public string saveName;


    public bool saveState = false;
    public bool loadState = false;
    public bool loadStateStart = false;

    [TextArea(1, 100)]
    public string details;

    public string[] GetStates()
    {
        if( Directory.Exists(Path.Combine(persistentDataPath, "states"))) {
            return System.IO.Directory.GetFiles(Path.Combine(persistentDataPath, "states"), "*.json")
                .Select(f=>Path.GetFileNameWithoutExtension(f)).ToArray();
        } else
        {
            return new string[0];
        }

    }

    private int lastCapturedFrame = Int32.MaxValue;
    private int lastEncodedFrame = Int32.MaxValue;
    // Update is called once per frame
    void LateUpdate()
    {
        this.frameCount = Time.frameCount;
        while(mainThreadActions.Count > 0)
        {
            mainThreadActions.Dequeue()?.Invoke();
        }

        if(shouldSendStateChange == true)
        {
            shouldSendStateChange = false;
            SendStateUpdate();
            details = GenerateUIState().ToString(true);
        }
        if (saveState)
        {
            saveState = false;
            SaveState(saveName);
        }

        if(loadStateStart && ABRManager.Instance != null)
        {
            LoadState(saveName, clearState:false);
            loadStateStart = false;
        }
        if(loadState)
        {
            LoadState(saveName);
        }
        mainDataScene = GameObject.FindObjectOfType<DataScene>()?.abrDataScene;

        mainDataScene?.dataScene?.transform.SetParent(dataSceneRoot, false);

        // Capture legend
        // Ensure we wait for the last frame to capture before we assign new inputs
        if (toEncode.Count > 0 && Time.frameCount > lastCapturedFrame + 1 && Time.frameCount > lastEncodedFrame + 1)
        {
            var encodeInfo = toEncode.Dequeue();
            var strategy = encodeInfo.Item1;
            var inputs = encodeInfo.Item2;
            var legendUUID = encodeInfo.Item3;

            // Keep track of which inputs have been modified so we can unset them after a screenshot has been captures
            List<string> modifiedInputs = new List<string>();

            foreach(var inputKey in inputs.keys)
            {

                var inputIndex = (strategy as ABRObject).GetInputIndex(inputKey);
                var existingInput = (strategy as ABRObject).GetInputValue(inputIndex);

                // Skip if it's already got an input
                if (existingInput != null)
                {
                    continue;
                }

                if (inputs[inputKey].IsNull)
                {
                    (strategy as ABRObject).AssignInput(inputKey, null);
                }
                else
                {
                    Guid guid = new Guid(inputs[inputKey].str);
                    ABRNode inputAssignment;
                    if (ABRManager.Instance.registeredNodes.TryGetValue(guid, out inputAssignment))
                    {
                        // Debug.Log(inputAssignment.GetType().Name + " node " + inputAssignment.UniqueID + " assigned to " + inputKey + " of " + strategy.GetType() + " node " + strategy.UniqueID);
                        (strategy as ABRObject).AssignInput(inputKey, inputAssignment);
                        modifiedInputs.Add(inputKey);
                    }
                }
                }

                var layerName = "";
                string[] layers = {"Glyph", "Surface", "Line"};
                foreach (var n in layers)
                {
                    if (strategy.GetType().Name.Contains(n))
                    {
                        layerName = n;
                    }
                }

                Debug.Log(string.Format("encode {0}: {1}", legendUUID, Time.frameCount));
                captureQueue.Add(Tuple.Create(legendUUID, layerName, Time.frameCount, modifiedInputs, strategy));
                lastEncodedFrame = Time.frameCount;
        }

        //  Ensure it's captured in the next frame
        List<int> toRemove = new List<int>();
        // foreach (var strategy in captureQueue)
        for (int i = 0; i < captureQueue.Count; i++)
        // if (captureQueue.Count > 0 && Time.frameCount > lastEncodedFrame)
        {
            var strategy = captureQueue[i];
            if (Time.frameCount != strategy.Item3 + 1)
            {
                continue;
            }

            Debug.Log(string.Format("capture {0}: {1}", strategy.Item1, Time.frameCount));
            byte[] imageArray = CaptureLegendView(800, 150, strategy.Item2, false);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            var viewMessage = JSONObject.Create(JSONObject.Type.OBJECT);
            viewMessage.AddField("uuid", strategy.Item1);
            viewMessage.AddField("bytes", base64ImageRepresentation);

            ABRMessenger.Instance.SendAbrMessage(new AbrMessage(AbrMessageType.LegendView, viewMessage.ToString(true)));

            // After the screenshot is captured, set the modified inputs back to null
            foreach (var inputKey in strategy.Item4)
            {
                (strategy.Item5 as ABRObject).AssignInput(inputKey, null);
            }
            toRemove.Add(i);
            lastCapturedFrame = Time.frameCount;
        }

        foreach (var s in toRemove)
        {
            captureQueue.RemoveAt(s);
        }
    }

    public void SaveState(string stateName, string directory = "", bool updateCurrentState=false, bool updateUI = true, bool isScreenshot = false) {
        if(directory == "")
        {
            directory = System.IO.Path.Combine(persistentDataPath, "states");
        }
        var savePath = System.IO.Path.Combine(directory, stateName + ".json");
        var screenshotPath = System.IO.Path.Combine(directory, stateName + ".png");
        var thumbnailPath = System.IO.Path.Combine(directory, stateName + "#thumbnail.png");

        if (!new FileInfo(savePath).Directory.Exists)
        {
            System.IO.Directory.CreateDirectory(new FileInfo(savePath).DirectoryName);
        }

        using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(savePath, false))
        {
            var stateJson = ABRManager.Instance.GenerateState();
            file.Write(stateJson.ToString(true));
        }

        var captureObject = FindObjectOfType<Screenshot>();
        if (updateCurrentState)
        {
            this.currentStateName = stateName;
        }
        mainThreadActions.Enqueue(() => {
            if(true) captureObject.Capture(screenshotPath, Screen.width * 1, Screen.height * 1, true);
            captureObject.Capture(thumbnailPath, 128,128, false);
            if (updateUI) OnABRStateChanged();
        });


    }

    public void LoadState(string stateName, bool clearState=true) {
        autosavePaused = true;
        Debug.Log(string.Format("Loading state {0}...", stateName));
        loadState = false;
        using (System.IO.StreamReader file =
            new System.IO.StreamReader(System.IO.Path.Combine(persistentDataPath,"states", stateName + ".json")))
        {
            ABRManager.Instance.LoadState(JSONObject.Create(file.ReadToEnd()), clearState);
        }
        var encodings = ABRManager.Instance.registeredNodes.Values.Where(n => n is ABREncoding).Select(n => n as ABREncoding) ;
        foreach(var encoding in encodings)
        {
            EncodingRenderStrategy strat = encoding.GetInputValue("Rendering Strategy") as EncodingRenderStrategy;
            if(strat != null)
                perStrategyEncodings.Add(strat, encoding);
        }
        JSONObject uiMetadata = ABRManager.Instance.GetUICacheJson();
        perNodeUIData.Clear();

        foreach (var nodeUuid in uiMetadata.keys)
        {
            Guid guid = new Guid(nodeUuid);
            if(ABRManager.Instance.registeredNodes.ContainsKey(guid))
            {
                var node = ABRManager.Instance.registeredNodes[guid];
                perNodeUIData[node] = uiMetadata[nodeUuid];

            }
        }

        Debug.Log("Done loading.");
        autosavePaused = false;
        OnABRStateChanged();
        this.currentStateName = stateName;
    }

    void UpdateLightCache()
    {
        lightCache.Clear();
        // Add to the light cache because actual light data can only be accessed
        // from the main thread
        foreach (var light in ABRManager.Instance.lightsToSave)
        {
            var lightJson = JSONObject.Create(JSONObject.Type.OBJECT);
            lightJson.AddField("intensity", light.intensity);

            var direction = light.transform.rotation.eulerAngles;
            lightJson.AddField("directionX", direction.x);
            lightJson.AddField("directionY", direction.y);
            lightJson.AddField("directionZ", direction.z);
            lightCache.Add(lightJson);
        }
    }

    // Need to change the encodings, then capture the legend entry
    Queue<Tuple<EncodingRenderStrategy, JSONObject, string>> toEncode = new Queue<Tuple<EncodingRenderStrategy, JSONObject, string>>();
    List<Tuple<string, string, int, List<string>, EncodingRenderStrategy>> captureQueue = new List<Tuple<string, string, int, List<string>, EncodingRenderStrategy>>();

    void SendLegendView(JSONObject legendEntryInfo)
    {
        string strategyTypeStr = legendEntryInfo.GetField("type").str;

        string uuid = legendEntryInfo.GetField("uuid").str;

        // Obtain the C# type from the string provided
        var assembly = System.Reflection.Assembly.GetExecutingAssembly();
        Type strategyType = assembly.GetType(strategyTypeStr);

        // Find this strategy in the state
        mainThreadActions.Enqueue(() =>
        {
            // Get the strategy that matches the type the user is asking for
            var specificStrategies = ABRManager.Instance.registeredNodes.Values.Where(n => n.GetType().Name == strategyTypeStr).Select(n => n as EncodingRenderStrategy);
            foreach (var strategy in specificStrategies)
            {
                var inputs = legendEntryInfo.GetField("inputs");
                toEncode.Enqueue(Tuple.Create(strategy, inputs, uuid));

            }
        });
    }

    public byte[] CaptureLegendView(int width, int height, string layerName, bool transparentBackground = true)
    {
        var mask = LayerMask.NameToLayer(layerName);

        var camera = this.captureCamera;
        var oldLayers = camera.cullingMask;
        camera.cullingMask = 1 << mask;

        RenderTexture rt = new RenderTexture(width, height, 24);
        Color temp = camera.backgroundColor;
        if(transparentBackground == true)
        {
            camera.backgroundColor = Color.clear;
        }
        camera.targetTexture = rt;
        Texture2D image = new Texture2D(width, height, TextureFormat.RGB24, false);
        camera.Render();


        RenderTexture.active = rt;
        image.ReadPixels(new Rect(0, 0, camera.pixelWidth, camera.pixelHeight), 0, 0);
        image.Apply();

        camera.targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);

        byte[] bytes = image.EncodeToPNG();

        camera.backgroundColor = temp;
        RenderTexture.active = null;
        camera.cullingMask = oldLayers;
        return bytes;
    }

}
