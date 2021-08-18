using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.IO;
using UnityEngine;



public interface IABRComputable
{
    bool NeedsUpdate { get; set; }
    bool IsUpdating { get; set; }
    Task ComputeUpdate();
}




public interface IABRNodeManager
{
    IAssignable GetNode(Guid guid);
    IAssignable GetNode(string label);
}



/// Delegate to be called when an AbrMessage is received from the client
public delegate void StateChangedHandler();


public class ABRManager : MonoBehaviour
{
    public void MarkStateChanged()
    {
        stateChanged = true;
    }
    bool stateChanged = false;

    public StateChangedHandler OnStateChangedEvent { get; set; }
    void OnStateChanged()
    {
        OnStateChangedEvent?.Invoke();
    }

    public Camera cameraToSave;
    public Light[] lightsToSave;
    public Transform[] transformsToSave;

    public static bool IsValidNode(IAssignable node)
    {
        if(node == null || node?.IsValid == false)
        {
            return false;
        } else
        {
            return true;
        }
    }
    static ABRManager _instance;
    public static ABRManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<ABRManager>();
            if (_instance == null)
                _instance = new GameObject("ABR Manager").AddComponent<ABRManager>();
            return _instance;
        }
    }

    public void DestroyNode(Guid guid)
    {
        ABRNode node;
        if(registeredNodes.TryGetValue(guid, out node))
        {
            node.Destroy();
            registeredNodes.Remove(guid);
        }
    }
    Dictionary<IAssignable, string> labels = new Dictionary<IAssignable, string>();
    Dictionary<Type, Dictionary<string, IAssignable>> interfaceLabelLookup = new Dictionary<Type, Dictionary<string, IAssignable>>();

    //Dictionary<SpecificLabel, HashSet<ABRNode>> pendingLabelAlerts = new Dictionary<SpecificLabel, HashSet<ABRNode>>();

    //Dictionary<SpecificLabel, HashSet<SpecificInput>> pendingLabelAssignment = new Dictionary<SpecificLabel, HashSet<SpecificInput>>();

    //Dictionary<Guid, HashSet<SpecificInput>> pendingGuidAssignment = new Dictionary<Guid, HashSet<SpecificInput>>();
    //Dictionary<Guid, HashSet<ABRSet>> pendingGuidAdditions = new Dictionary<Guid, HashSet<ABRSet>>();

    //Dictionary<ABRSet, Guid> backPendingGuidAdditions = new Dictionary<ABRSet, Guid>();

    //Dictionary<SpecificInput, SpecificLabel> backPendingLabelAssignments = new Dictionary<SpecificInput, SpecificLabel>();

    //Dictionary<SpecificInput, Guid> backPendingGuidAssignments = new Dictionary<SpecificInput, Guid>();

    Queue<Action> mainThreadActions = new Queue<Action>();


    HashSet<IABRComputable> computableObjects = new HashSet<IABRComputable>();



    public Dictionary<Guid, ABRNode> registeredNodes = new Dictionary<Guid, ABRNode>();

    public void ClearState()
    {
        labels.Clear();
        interfaceLabelLookup.Clear();
        //pendingLabelAlerts.Clear();
        //pendingLabelAssignment.Clear();
        //pendingGuidAssignment.Clear();
        //backPendingGuidAdditions.Clear();
        //backPendingGuidAssignments.Clear();
        mainThreadActions.Clear();

        computableObjects.Clear();


        List<Task> handlingTasks = new List<Task>();

        // Destroy nodes
        BoolReference handlingDelete = new BoolReference(false);

        foreach (var node in registeredNodes.Values)
        {
            node.Destroy();
            handlingTasks.Add(AsyncUtilities.UntilTrue(() => node.IsDestroyed == true));
        }
        //Debug.Log("Waiting for all nodes to destroy");
        Task.WhenAll(handlingTasks).Wait();
        //Debug.Log("All nodes are destroyed");

        registeredNodes.Clear();
        if (uiCacheJson != null)
        {
            uiCacheJson.Clear();
        }
        uiCacheJson = JSONObject.Create(JSONObject.Type.OBJECT);


        GetComponent<VisAssetManager>().LoadLibrary();
    }

    public void RemoveNode(ABRNode node)
    {
        node.ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.Deleted, Sender = node });
    }

    JSONObject uiCacheJson;

    public JSONObject GetUICacheJson() { return uiCacheJson; }

    public bool TryDownloadingVisAssets = false;
    public void LoadState(JSONObject state, bool clearState)
    {
        if (clearState)
        {
            ClearState();
        }

        JSONObject compositionNodesJson = state["compositionNodes"];
        JSONObject dataNodesJson = state["dataNodes"];
        JSONObject visassetNodesJson = state["visassetNodes"];
        JSONObject sceneJson = state.HasField("sceneData")? state["sceneData"] : null;
        JSONObject stateVisassets = state["stateSpecificVisassets"];

        foreach (var visAsset in visassetNodesJson.list)
        {
            var guid = new Guid(visAsset.GetField("uuid").str);
            if(!ABRManager.Instance.registeredNodes.ContainsKey(guid))
            {
                // First, look in state-specific vis assets to see if it's there
                var stateVisAsset = stateVisassets?.list.Find((v) => new Guid(v.GetField("uuid").str) == guid);

                if (stateVisAsset != null)
                {
                    // If found, load it from the state
                    try { VisAssetManager.Instance.LoadVisassetFromJson(stateVisAsset); } catch (Exception e) { Debug.LogError(e); }
                }

                if (stateVisAsset == null && TryDownloadingVisAssets)
                {
                    // If still not found, then try downloading the vis asset
                    try { VisAssetManager.Instance.DownloadVisAsset(visAsset.GetField("uuid").str, true); } catch (Exception e) { Debug.LogError(e); }
                }
            }
        }

        if (sceneJson?.HasField("camera") ?? false)
        {
            cameraToSave.fieldOfView = sceneJson.GetField("camera").GetField("fieldOfView").f;
        }


        if (sceneJson?.HasField("lights") ?? false)
        {
            var lightsJson = sceneJson.GetField("lights");
            foreach (Light l in lightsToSave)
            {
                if(lightsJson.HasField(l.name))
                {
                    l.intensity = lightsJson.GetField(l.name).GetField("intensity").f;
                    l.colorTemperature = lightsJson.GetField(l.name)?.GetField("colorTemperature")?.f ?? 6500;
                    l.color = (Color)JsonUtility.FromJson(lightsJson.GetField(l.name).GetField("color").ToString(), typeof(Color));
                }
            }
        }

        if (sceneJson?.HasField("transforms") ?? false)
        {
            var transformsJson = sceneJson.GetField("transforms");
            foreach (Transform l in transformsToSave)
            {
                if (l == null) continue;
                if (transformsJson.HasField(l.name))
                {
                    l.localPosition = (Vector3)JsonUtility.FromJson(transformsJson.GetField(l.name).GetField("localPosition").ToString(), typeof(Vector3));
                    l.localRotation = (Quaternion)JsonUtility.FromJson(transformsJson.GetField(l.name).GetField("localRotation").ToString(), typeof(Quaternion));
                    l.localScale = (Vector3)JsonUtility.FromJson(transformsJson.GetField(l.name).GetField("localScale").ToString(), typeof(Vector3));
                }
            }
        }
        // Read and try loading data for each dataObject
        foreach (var dataNodeJson in dataNodesJson.list)
        {
            var node = CreateNode(Type.GetType(dataNodeJson["type"].str),new Guid(dataNodeJson["uuid"].str));
            if (dataNodeJson.HasField("label"))
            {
                SetNodeLabel(node, dataNodeJson["label"].str);
            }
            if(node is DataObject)
            {
                

                ((DataObject)node).dataset = DataManager.Instance.TryLoadDatasetFromDisk(dataNodeJson["label"].str);
            }
            if(node is RawDataVariable)
            {
                ((RawDataVariable)node).VariableName = dataNodeJson["variableName"].str;
            }
            if(node is RawScalarDataVariable)
            {
                ((RawScalarDataVariable)node).minValue= dataNodeJson["minValue"].f;
                ((RawScalarDataVariable)node).maxValue = dataNodeJson["maxValue"].f;



            }


        }


        // Create all the composition nodes before setting up their connections
        foreach (var compositionNodeJson in compositionNodesJson.list)
        {
            var node = CreateNode(Type.GetType(compositionNodeJson["type"].str), new Guid(compositionNodeJson["uuid"].str));
            if (compositionNodeJson.HasField("label"))
            {
                SetNodeLabel(node, compositionNodeJson["label"].str);
            }
        }

        foreach (var compositionNodeJson in compositionNodesJson.list.Where(cn => typeof(ISourceable).IsAssignableFrom(Type.GetType(cn["type"].str))))
        {
            Guid guid = new Guid(compositionNodeJson["uuid"].str);
            ABRNode node = registeredNodes[guid];
            ABRNode.Deserialize(compositionNodeJson, node);
        }

        // Now that the composition nodes are created, make the connections
        foreach (var compositionNodeJson in compositionNodesJson.list.Where(cn => !typeof(ISourceable).IsAssignableFrom(Type.GetType(cn["type"].str))))
        {
            Guid guid = new Guid(compositionNodeJson["uuid"].str);
            ABRNode node = registeredNodes[guid];
            ABRNode.Deserialize(compositionNodeJson, node);
        }

        if (state.HasField("ui"))
        {
            uiCacheJson = state["ui"];
        } else
        {
            uiCacheJson = JSONObject.Create(JSONObject.Type.OBJECT);
        }

        // Hack to ensure hidden objects show up correctly
        foreach(var rs in registeredNodes.Values.Where(n => n is EncodingRenderStrategy).Select(n => n as EncodingRenderStrategy))
        {
            var rsUUID = rs.UniqueID.ToString();
            if (uiCacheJson.HasField(rsUUID))
            {
                bool hidden = uiCacheJson.GetField(rsUUID).GetField("hidden")?.b ?? false;
                rs.Hidden = hidden;
            }
        }

        foreach(var n in registeredNodes.Values) {
            Debug.Log(n.GetType().Name);
        }
        foreach(var dataScene in registeredNodes.Values.Where(n => n is ABRDataScene).Select(n => n as ABRDataScene))
        {
            dataScene.UpdateAllEncodingObjects();
        }
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


    public JSONObject GenerateState()
    {
        JSONObject stateJson = JSONObject.Create(JSONObject.Type.OBJECT);

        JSONObject compositionNodesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        JSONObject dataNodesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        JSONObject visassetNodesJson = JSONObject.Create(JSONObject.Type.ARRAY);
        foreach (var node in registeredNodes.Values)
        {
            if(node is RawDataVariable || node is DataObject)
            {
                dataNodesJson.Add(ABRNode.Serialize(node));
            } else if (node is IVisAsset)
            {
                visassetNodesJson.Add(ABRNode.Serialize(node));
            } else
            {
                compositionNodesJson.Add(ABRNode.Serialize(node));
            }
        }
        stateJson.AddField("dataNodes", dataNodesJson);
        stateJson.AddField("visassetNodes", visassetNodesJson);
        stateJson.AddField("compositionNodes", compositionNodesJson);

        JSONObject stateVisAssets = JSONObject.Create(JSONObject.Type.ARRAY);
        // Find all of the state-specific VisAssets and put them into the state
        foreach (var va in visassetNodesJson.list)
        {
            var uuid = va.GetField("uuid").str;
            string visAssetPath = Path.Combine(
                VisAssetManager.Instance.dataPath,
                VisAssetManager.Instance.libraryPath,
                uuid.ToString()
            );
            string artifactJsonPath = Path.Combine(
                visAssetPath,
                VisAssetManager.VISASSET_JSON
            );
            var jsonMetadata = VisAssetManager.Instance.GetArtifactMetadata(artifactJsonPath);

            // Make sure it's eligible to be saved to state
            if (jsonMetadata.GetField("stateSpecific")?.b ?? false)
            {
                // Right now only colormaps are supported
                if (jsonMetadata.GetField("type").str != "colormap")
                {
                    Debug.LogError("Only colormaps can be saved to state-specific VisAssets");
                }

                // Load the colormap xml data
                var contents = File.ReadAllText(Path.Combine(visAssetPath, "colormap.xml"));
                jsonMetadata.AddField("contents", contents.Replace("\"", "\\\""));

                stateVisAssets.Add(jsonMetadata);
            }
        }
        // Add specific visassets into the state
        stateJson.AddField("stateSpecificVisassets", stateVisAssets);

        JSONObject sceneData = JSONObject.Create(JSONObject.Type.OBJECT);
        JSONObject camera = JSONObject.Create(JSONObject.Type.OBJECT);
        camera.AddField("fieldOfView", cameraToSave.fieldOfView);

        JSONObject lights = JSONObject.Create(JSONObject.Type.OBJECT);
        foreach(var l in lightsToSave)
        {
            JSONObject lightJson = JSONObject.Create(JSONObject.Type.OBJECT);
            lightJson.AddField("intensity", l.intensity);
            lightJson.AddField("color", JSONObject.Create(JsonUtility.ToJson(l.color)));
            lightJson.AddField("colorTemperature", l.colorTemperature);

            lights.AddField(l.gameObject.name, lightJson);

        }

        JSONObject transforms = JSONObject.Create(JSONObject.Type.OBJECT);
        foreach(var t in transformsToSave)
        {
            if (t == null) continue;
            JSONObject transformJson = JSONObject.Create(JSONObject.Type.OBJECT);
            transformJson.AddField("localPosition", JSONObject.Create(JsonUtility.ToJson(t.localPosition)));
            transformJson.AddField("localRotation", JSONObject.Create(JsonUtility.ToJson(t.localRotation)));
            transformJson.AddField("localScale", JSONObject.Create(JsonUtility.ToJson(t.localScale)));
            transforms.AddField(t.gameObject.name, transformJson);
        }

        sceneData.AddField("camera", camera);
        sceneData.AddField("lights", lights);
        sceneData.AddField("transforms", transforms);
        stateJson.AddField("sceneData", sceneData);
        stateJson.AddField("ui", uiCacheJson);
        return stateJson;
    }

    public static T CreateNode<T>() where T : ABRNode
    {
        return (T)CreateNode(typeof(T));
    }

    public static T CreateNode<T>(Guid guid) where T : ABRNode
    {
        return (T)CreateNode(typeof(T), guid);
    }

    public static T CreateNode<T>(Guid guid, params object[] list) where T : ABRNode
    {
        return (T)CreateNode(typeof(T), guid, list);
    }

    public static T CreateNode<T>(params object[] list) where T : ABRNode
    {
        return (T)CreateNode(typeof(T), list);
    }

    public static ABRNode CreateNode(Type nodeType)
    {
        return CreateNode(nodeType, Guid.Empty);
    }


    public static ABRNode CreateNode(Type nodeType, Guid guid)
    {
        ABRNode newObject = (ABRNode)Activator.CreateInstance(nodeType);

        newObject.UniqueID = guid;

        RegisterNode(newObject);
        return newObject;
    }


    public static ABRNode CreateNode(Type nodeType, params object[] list)
    {
        return CreateNode(nodeType, Guid.Empty, list);
    }
    public static ABRNode CreateNode(Type nodeType, Guid guid, params object [] list)
    {

        var ctors = nodeType.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
        ConstructorInfo ctorMatch = null;

        // Find a constructor that has params that are assignable from the provided params
        foreach(var constructor in ctors)
        {
            var parameters = constructor.GetParameters();
            if (list.Length != parameters.Length) continue;
            bool failedMatch = false;
            for(int p = 0; p < list.Length && failedMatch == false; p++)
            {
                if (parameters[p].ParameterType.IsAssignableFrom(list[p].GetType()) == false) {
                    failedMatch = true;
                }
            }
            if(failedMatch == false)
            {
                ctorMatch = constructor;
                break;
            }
        }

        if(ctorMatch != null)
        {
            ABRNode newObject = (ABRNode)ctorMatch.Invoke(list);
            newObject.UniqueID = guid;

            RegisterNode(newObject);

            
            return newObject;


        } else
        {
            return null;
        }
    }



    IEnumerable<Type> getNodeInterfaces(IAssignable node)
    {
        return node.GetType().GetInterfaces().Where(i => typeof(IAssignable).IsAssignableFrom(i));

    }

    void removeLabelInterfaces(IEnumerable<Type> interfaces, string label)
    {
        foreach (var i in interfaces)
        {
            Dictionary<string, IAssignable> labelTable;
            if (interfaceLabelLookup.TryGetValue(i, out labelTable))
            {
                labelTable.Remove(label);
            }
        }
    }
    public void ClearNodeLabel(ABRNode node)
    {
        var interfaces = getNodeInterfaces(node);
        string oldLabel;

        if (labels.TryGetValue(node, out oldLabel) == true)
        {
            removeLabelInterfaces(interfaces, oldLabel);
        }

    }

    public string GetNodeLabel(IAssignable node)
    {
        string label;
        if (node != null && labels.TryGetValue(node, out label) == true)
            return label;
        else
            return "" ;
    }


    public void SetNodeLabel(IAssignable node, string label, bool indexForLookup = true)
    {
        var interfaces = getNodeInterfaces(node);

        string oldLabel; 
     
        if(labels.TryGetValue(node, out oldLabel) == true)
        {
            removeLabelInterfaces(interfaces, oldLabel);
        }


        //Instance.SendAlertsForAddedLabeledNode((ABRNode)node);

        if (label != "")
        {
            labels[node] = label;

            if (indexForLookup)
            {
                foreach (var i in interfaces)
                {
                    Dictionary<string, IAssignable> labelTable;
                    if (interfaceLabelLookup.TryGetValue(i, out labelTable))
                    {
                        labelTable[label] = node;
                    }
                    else
                    {
                        (interfaceLabelLookup[i] = new Dictionary<string, IAssignable>())[label] = node;

                    }
                }
            }

            //    Instance.ResolveAnyPendingLabelAssignments((ABRNode)node);
            //    Instance.SendAlertsForAddedLabeledNode((ABRNode)node);
        }

    }
    class SpecificLabel : Tuple<Type, string>
    {
        public SpecificLabel(Type type, string label) : base(type, label) { }
    }
    class SpecificInput : Tuple<ABRObject, int>
    {
        public SpecificInput(ABRObject node, int inputIndex) : base(node, inputIndex) { }
    }



    //public void WatchLabel(ABRNode requestingNode, Type interfaceType, string label)
    //{
    //    SpecificLabel specificLabel = new SpecificLabel(interfaceType, label);
    //    HashSet<ABRNode> nodes;
    //    if (!pendingLabelAlerts.TryGetValue(specificLabel, out nodes))
    //    {
    //        pendingLabelAlerts.Add(specificLabel, nodes = new HashSet<ABRNode>());
    //    }
    //    nodes.Add(requestingNode);
    //    if(false)Debug.Log("NOW WATCHING LABEL " + label);
    //}


    //public void AwaitItemFromLabel(ABRNode requestingNode, Type interfaceType, string label)
    //{
    //    SpecificLabel specificLabel = new SpecificLabel(interfaceType, label);
    //    HashSet<ABRNode> nodes;
    //    if(pendingLabelAlerts.TryGetValue(specificLabel, out nodes))
    //    {
    //        nodes.Add(requestingNode);
    //    }
    //}

    //protected void SendAlertsForRemovedLabeledNode(ABRNode labeledNode)
    //{
    //    string label = GetNodeLabel(labeledNode);
    //    if (label == "") return;

    //    // Need to consider requests made in behalf of any of this node's available interfaces
    //    var assignableInterfaces = labeledNode.GetType().GetInterfaces().Where(i => typeof(IAssignable).IsAssignableFrom(i));

    //    foreach (var assignableInterface in assignableInterfaces)
    //    {
    //        HashSet<ABRNode> pendingAlerts = null;

    //        SpecificLabel specificLabel = new SpecificLabel(assignableInterface, label);
    //        if (pendingLabelAlerts.TryGetValue(specificLabel, out pendingAlerts))
    //        {
    //            // Queue up any assignment requests that were awaiting this object
    //            Queue<ABRNode> nodesToAlert = new Queue<ABRNode>();
    //            foreach (var assignment in pendingAlerts)
    //            {
    //                nodesToAlert.Enqueue(assignment);
    //            }

    //            // apply any assignment requests

    //            foreach (var nodetoAlert in nodesToAlert)
    //            {
    //                nodetoAlert.ReceiveMessage(
    //                    new ABRUpdateMessage
    //                    {
    //                        Sender = null,
    //                        Type = ABRUpdateMessage.UpdateType.ItemRemoved,
    //                        UpdateInfo = new ABRUpdateMessage.ItemInfo { Item = labeledNode },
    //                        Message = "The label " + label + " is no longer assigned to " + labeledNode
    //                    }
    //                );

    //            }


    //        }
    //    }
    //}


    //protected void SendAlertsForAddedLabeledNode(ABRNode labeledNode)
    //{
    //    string label = GetNodeLabel(labeledNode);
    //    if (label == "") return;

    //    // Need to consider requests made in behalf of any of this node's available interfaces
    //    var assignableInterfaces = labeledNode.GetType().GetInterfaces().Where(i => typeof(IAssignable).IsAssignableFrom(i));

    //    foreach (var assignableInterface in assignableInterfaces)
    //    {
    //        HashSet<ABRNode> pendingAlerts = null;

    //        SpecificLabel specificLabel = new SpecificLabel(assignableInterface, label);
    //        if (pendingLabelAlerts.TryGetValue(specificLabel, out pendingAlerts))
    //        {
    //            // Queue up any assignment requests that were awaiting this object
    //            Queue<ABRNode> nodesToAlert = new Queue<ABRNode>();
    //            foreach (var assignment in pendingAlerts)
    //            {
    //                nodesToAlert.Enqueue(assignment);
    //            }

    //            // apply any assignment requests

    //            foreach (var nodetoAlert in nodesToAlert)
    //            {
    //                nodetoAlert.ReceiveMessage(
    //                    new ABRUpdateMessage
    //                    {
    //                        Sender = null,
    //                        Type = ABRUpdateMessage.UpdateType.ItemAdded,
    //                        UpdateInfo = new ABRUpdateMessage.ItemInfo { Item = labeledNode },
    //                        Message = "The label " + label + " is now assigned to " + labeledNode

    //                    }
    //                );

    //            }

    //            // Let's not automatically remove these alert requests, now that we can listen for label changes.

    //            //// Now we can remove these pending requests
    //            //pendingAlerts.Clear();
    //            //pendingLabelAssignment.Remove(specificLabel);
    //        }
    //    }
    //}

    //public void RemoveAwaitItemFromLabel(ABRNode requestingNode, Type interfaceType, string label)
    //{
    //    SpecificLabel specificLabel = new SpecificLabel(interfaceType, label);
    //    HashSet<ABRNode> nodes;
    //    if (pendingLabelAlerts.TryGetValue(specificLabel, out nodes))
    //    {
    //        nodes.Remove(requestingNode);
    //    }
    //}


    //public void RegisterInputAssignment(ABRObject node, int inputIndex)
    //{
    //    var specificInput = new SpecificInput(node, inputIndex);

    //    SpecificLabel specificLabel;
    //    if(backPendingLabelAssignments.TryGetValue(specificInput, out specificLabel))
    //    {
    //        pendingLabelAssignment[specificLabel].Remove(specificInput);
    //        if(false)Debug.Log("Cleared a pending label assignment");

    //    }

    //    Guid guid;
    //    if (backPendingGuidAssignments.TryGetValue(specificInput, out guid))
    //    {
    //        if(pendingGuidAssignment.ContainsKey(guid))
    //            pendingGuidAssignment[guid].Remove(specificInput);
    //        if(false)Debug.Log("Cleared a pending guid assignment");
    //    }

    //}
    public void AssignInputFromLabel(ABRObject node, string inputName, string label)
    {
        AssignInputFromLabel(node, node.GetInputIndex(inputName), label);
    }

    public void AssignInputFromLabel(ABRObject node, int inputIndex, string label)
    {
        ABRNode inputObject = FindNodeForLabel(node.GetInputType(inputIndex), label) as ABRNode;

        if (inputObject == null)
        {
            //// Save as a pending assignment
            //SpecificLabel specificLabel = new SpecificLabel(node.GetInputType(inputIndex), label);

            //HashSet<SpecificInput> pendingAssignemnts = null;
            //if (!pendingLabelAssignment.TryGetValue(specificLabel, out pendingAssignemnts))
            //{
            //    pendingLabelAssignment.Add(specificLabel, pendingAssignemnts = new HashSet<SpecificInput>());
            //}
            //var specificInput = new SpecificInput(node, inputIndex);
            //pendingAssignemnts.Add(specificInput);
            //if(false)Debug.Log("Added a pending label assignment " + node + "[" + inputIndex + "] = " + label);

            //backPendingLabelAssignments[specificInput] = specificLabel;
        } else
        {
            node.AssignInput(inputIndex, inputObject);
        }
    }


    public void AddItemFromGuid(ABRSet node, Guid guid)
    {
        ABRNode inputObject = FindNodeForGuid(guid) as ABRNode;
        if (inputObject == null)
        {
            //// Save as a pending assignment

            //HashSet<ABRSet> pendingAdditions = null;
            //if (!pendingGuidAdditions.TryGetValue(guid, out pendingAdditions))
            //{
            //    pendingGuidAdditions.Add(guid, pendingAdditions = new HashSet<ABRSet>());
            //}

            //pendingAdditions.Add(node);
            //backPendingGuidAdditions[node] = guid;
            //Debug.Log("Added a pending guid addition " + node + " = " + guid);


        }
        else
        {
            node.Add(inputObject);
        }
    }

    public void AssignInputFromGuid(ABRObject node, string inputName, Guid guid)
    {
        AssignInputFromGuid(node, node.GetInputIndex(inputName), guid);
    }
    public void AssignInputFromGuid(ABRObject node, int inputIndex, Guid guid)
    {
        ABRNode inputObject = FindNodeForGuid(guid) as ABRNode;

        if (inputObject == null)
        {
            //// Save as a pending assignment

            //HashSet<SpecificInput> pendingAssignemnts = null;
            //if (!pendingGuidAssignment.TryGetValue(guid, out pendingAssignemnts))
            //{
            //    pendingGuidAssignment.Add(guid, pendingAssignemnts = new HashSet<SpecificInput>());
            //}
            //var specificInput = new SpecificInput(node, inputIndex);

            //pendingAssignemnts.Add(specificInput);
            //backPendingGuidAssignments[specificInput] = guid ;
            //Debug.Log("Added a pending guid assignment " + node + "[" + inputIndex + "] = " + guid);


        }
        else
        {
            node.AssignInput(inputIndex, inputObject);
        }
    }
    public I FindNodeForLabel<I>(string label) where I : IAssignable
    {
        return (I)FindNodeForLabel(typeof(I), label);
    }
    public IAssignable FindNodeForLabel(string label)
    {
        return FindNodeForLabel(typeof(IAssignable), label);
    }

    public IAssignable FindNodeForLabel(Type nodeInterface, string label)
    {
        Dictionary<string, IAssignable> labelTable;

        if(interfaceLabelLookup.TryGetValue(nodeInterface, out labelTable))
        {
            IAssignable node;
            if(labelTable.TryGetValue(label, out node))
                return node;
        }
        return null;
    }

    //protected void ResolveAnyPendingGuidAssignments(ABRNode node)
    //{
    //    HashSet<SpecificInput> pendingAssignments = null;
    //    if (pendingGuidAssignment.TryGetValue(node.UniqueID, out pendingAssignments))
    //    {

    //        Queue<SpecificInput> assignments = new Queue<SpecificInput>();
    //        foreach (var assignment in pendingAssignments)
    //        {
    //            assignments.Enqueue(assignment);
    //        }

    //        // Resolve any request that were awaiting this object
    //        foreach (var assignment in assignments)
    //        {
    //            if (assignment.Item1.GetInputValue(assignment.Item2) == null)
    //            {
    //                assignment.Item1.AssignInput(assignment.Item2, node);
    //                Debug.Log("resolved a pending guid assignment " + assignment.Item1 + "[" + assignment.Item2 + "] = " + node.UniqueID);
    //            }
    //        }

    //        // Now we can remove these pending requests
    //        pendingAssignments.Clear();
    //        pendingGuidAssignment.Remove(node.UniqueID);

    //    }
    //}
    //protected void ResolveAnyPendingLabelAssignments(ABRNode node)
    //{
    //    string label = GetNodeLabel(node);
    //    if (label == "") return;



    //    // Need to consider requests made in behalf of any of this node's available interfaces
    //    var assignableInterfaces = node.GetType().GetInterfaces().Where(i => typeof(IAssignable).IsAssignableFrom(i));

    //    foreach(var assignableInterface in assignableInterfaces)
    //    {
    //        HashSet<SpecificInput> pendingAssignments = null;

    //        SpecificLabel specificLabel = new SpecificLabel(assignableInterface, label);
    //        if (pendingLabelAssignment.TryGetValue(specificLabel, out pendingAssignments))
    //        {
    //            // Queue up any assignment requests that were awaiting this object
    //            Queue<SpecificInput> assignments = new Queue<SpecificInput>();
    //            foreach (var assignment in pendingAssignments)
    //            {
    //                assignments.Enqueue(assignment);
    //            }

    //            // apply any assignment requests

    //            foreach (var assignment in assignments)
    //            {
    //                if (assignment.Item1.GetInputValue(assignment.Item2) == null)
    //                {
    //                    assignment.Item1.AssignInput(assignment.Item2, node);
    //                    Debug.Log("resolved a pending guid assignment " + assignment.Item1 + "[" + assignment.Item2 + "] = " + label);
    //                }
    //            }

    //            // Now we can remove these pending requests
    //            pendingAssignments.Clear();
    //            pendingLabelAssignment.Remove(specificLabel);
    //        }
    //    }

        
    //}

    public IAssignable FindNodeForGuid(Guid guid)
    {

        ABRNode node;
        if (registeredNodes.TryGetValue(guid, out node))
        {
            return node;
        }
        return null;
    }


    static public void RegisterNode(ABRNode node)
    {
        if(node is IABRComputable)
        {
            Instance.computableObjects.Add(node as IABRComputable);
        }

        if(node is EncodingSet)
        {
            Instance.EncodingSets.Add(node);
        }

        if (Instance.registeredNodes.ContainsKey(node.UniqueID))
            Debug.LogError("Already registered an object with the unique ID " + node.UniqueID);
        else
            Instance.registeredNodes[node.UniqueID] = node;

 


        //Instance.ResolveAnyPendingGuidAssignments(node);

        Instance.OnStateChanged();
    }


    

    static public void QueueMainThreadAction(Action action) {
        Instance.mainThreadActions.Enqueue(action);
    }



    ABRSet _encodingSets;
    ABRSet EncodingSets
    {
        get
        {
            if(_encodingSets == null)
            {
                _encodingSets = new ABRSet();
            }
            return _encodingSets;
        }
    }

    [TextArea(25,25)]
    public string details;
    // Start is called before the first frame update
    void Start()
    {
        uiCacheJson = JSONObject.Create(JSONObject.Type.OBJECT);
    }

    // Update is called once per frame
    bool first = true;
    void Update()
    {




        if(first)
        {
            first = false; return;
        }
        foreach(var item in computableObjects)
        {
            if(item.NeedsUpdate && item.IsUpdating == false)
            {
                item.ComputeUpdate();
            }
        }


        while(mainThreadActions.Count > 0)
        {
            mainThreadActions?.Dequeue()?.Invoke();
        }


        if(stateChanged)
        {
            stateChanged = false;
            OnStateChanged();
        }
















        // Debug display
        /*
        details = "";

        details += "REGISTERED OBJECTS:\n";

        foreach(var item in registeredNodes.Values)
        {
            details += item + " " + item.UniqueID.ToString().Substring(0, 4) + "..." +" " + item.UniqueID.ToString().Substring(0, 4) + "..." + "\n";
        }

        details += "\nCOMPUTABLE OBJECTS:\n";

        foreach (var item in computableObjects)
        {
            details += item +  " (" + (item.NeedsUpdate ? "Needs update" :"" ) + (item.IsUpdating ? "IsUpdating" : ""  ) + ")" + "\n";
        }


        foreach(var interfaceKey in interfaceLabelLookup.Keys)
        {
            details += "\nInterface: " + interfaceKey.Name + "\n";
            foreach(var label in interfaceLabelLookup[interfaceKey].Keys)
            {
                details += "- " + label + " (" + interfaceLabelLookup[interfaceKey][label] + ") " + interfaceLabelLookup[interfaceKey][label].UniqueID.ToString().Substring(0,4) +"..." + "\n";

            }


        }
        */

    }
}
