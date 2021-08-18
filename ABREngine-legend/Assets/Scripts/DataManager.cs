using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using VTK;



//[ExecuteInEditMode]
public class DataManager : MonoBehaviour, IABRNodeManager
{

    // Begin singleton code


    // Check to see if we're about to be destroyed.
    private static bool m_ShuttingDown = false;
    private static object m_Lock = new object();
    private static DataManager m_Instance;

    private string dataPath;

    /// <summary>
    /// Access singleton instance through this propriety.
    /// </summary>
    public static DataManager Instance
    {
        get
        {
            if (m_ShuttingDown)
            {
                Debug.LogWarning("[Singleton] Instance '" + typeof(DataManager) +
                    "' already destroyed. Returning null.");
                return null;
            }

            //lock (m_Lock)
            {
                if (m_Instance == null)
                {
                    // Search for existing instance.
                    m_Instance = (DataManager)FindObjectOfType(typeof(DataManager));

                    // Create new instance if one doesn't already exist.
                    if (m_Instance == null)
                    {
                        // Need to create a new GameObject to attach the singleton to.
                        var singletonObject = new GameObject();
                        m_Instance = singletonObject.AddComponent<DataManager>();
                        singletonObject.name = typeof(DataManager).ToString() + " (Singleton)";

                        // Make instance persistent.
                        DontDestroyOnLoad(singletonObject);
                    }
                }

                return m_Instance;
            }
        }
    }


    void Start()
    {
        m_ShuttingDown = false;
        this.dataPath = Path.Combine(Application.persistentDataPath, "media", "datasets");
    }
    private void OnApplicationQuit()
    {
        m_ShuttingDown = true;
    }


    private void OnDestroy()
    {
        m_ShuttingDown = true;
    }



    // End singleton code

    //private Dictionary<string, DataObject> _dataObjects;

    //private Dictionary<string, DataVariable> _dataVariables;

    [SerializeField, HideInInspector]
    private List<string> dataObjectLabels = new List<string>();

    [SerializeField, HideInInspector]
    private List<string> dataVariableLabels = new List<string>();


    private Dictionary<string, Dataset> heldDataSets = new Dictionary<string, Dataset>();

    private Queue<Action> updateActions = new Queue<Action>();

    //void RepopulateDataObjects()
    //{
    //    if (_dataObjects == null)
    //    {
    //        dataObjectLabels = new List<string>();
    //    }
    //    else
    //    {
    //        dataObjectLabels = new List<string>(_dataObjects?.Keys);
    //    }
    //}

    //void RepopulateDataVariables()
    //{
    //    //if (_dataVariables == null)
    //    //{
    //    //    dataVariableLabels = new List<string>();
    //    //}
    //    //else
    //    //{
    //    //    dataVariableLabels = new List<string>(_dataVariables?.Keys);
    //    //}
    //}

    //public List<string> GetLables()
    //{
    //    return dataObjectLabels;
    //}
    public void ReleaseHold()
    {

        foreach (var keyValue in heldDataSets)
        {
            string label = keyValue.Key;
            Dataset dataset = keyValue.Value;
            //BoolReference b = handlingBools[label];
            updateActions.Enqueue(() =>
            {
                ApplyDataset(label, dataset);
            });

            //b.state = true;
        }

        heldDataSets.Clear();
        handlingBools.Clear();
    }

    private Dictionary<string, BoolReference> handlingBools = new Dictionary<string, BoolReference>();
    public void HandleVtkDataset(string label, vtkDataSet vtkDataset, bool shouldHold, BoolReference handlingDone)
    {

        var dataset = DatasetBuilder.BuildMeshArrays(vtkDataset);
        if(dataset != null)
        {
            Debug.Log("Took in a dataset at " + dataset.bounds.center);
            if (shouldHold)
            {
                heldDataSets[label] = dataset;
            }
            else
            {
                ApplyDataset(label, dataset);

            }
        }
        handlingDone.state = true;




    }

    public Dataset TryLoadDatasetFromDisk(string label)
    {
        System.IO.FileInfo dataFile = new System.IO.FileInfo(Path.Combine(this.dataPath, label + ".json"));
        Dataset dataset = null;
        if(dataFile.Exists)
            using (System.IO.StreamReader file =
                new System.IO.StreamReader(dataFile.FullName, false))
            {
                dataset = (Dataset)JsonUtility.FromJson(file.ReadToEnd(),typeof(Dataset));
            }
        return dataset;
    }
    public bool cacheDataSets = false;
    private void ApplyDataset(string label, Dataset dataset)
    {
        if(cacheDataSets)
        {
            Debug.Log("Saving " + label + " to " + this.dataPath);
            System.IO.FileInfo dataFile = new System.IO.FileInfo(System.IO.Path.Combine(this.dataPath, label + ".json"));
            if (!dataFile.Directory.Exists)
            {
                System.IO.Directory.CreateDirectory(dataFile.DirectoryName);
            }
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(dataFile.FullName, false))
            {
                file.Write(JsonUtility.ToJson(dataset).ToString());
            }
        }
       
       
        var dataObject = GetDataObject(label);
        if (dataObject == null)
        {
            dataObject = CreateDataObject(label);

        }
        dataObject.dataset = dataset;
        //else
        //{
        //    dataObject.SetDataset(dataset);
        ReadVariables(dataObject);

        (dataObject as ABRNode).ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.Unknown, Message = "got new data from Paraview" });

        //}

    }

    public delegate void OnNewDataLabelDelegate(DataObject dataObject);
    public OnNewDataLabelDelegate OnNewDataLabel;

    private DataObject CreateDataObject(string dataObjectLabel)
    {
        DataObject dataObject = ABRManager.CreateNode<DataObject>();
        ABRManager.Instance.SetNodeLabel(dataObject, dataObjectLabel,true);

        return dataObject;
    }

    private void ReadVariables(IDataObject dataObject)
    {

        foreach (var scalarArrayName in dataObject.dataset.scalarArrayNames)
        {

            IScalarDataVariable scalarDataVariable = ABRManager.Instance.FindNodeForLabel(typeof(IScalarDataVariable), scalarArrayName) as IScalarDataVariable;
                
            if(scalarDataVariable == null)
            {
                scalarDataVariable = ABRManager.CreateNode<RawScalarDataVariable>();
                (scalarDataVariable as RawScalarDataVariable).VariableName = scalarArrayName;
                ABRManager.Instance.SetNodeLabel(scalarDataVariable, scalarArrayName);

            }

            // If the type is a RangedScalarDataVariable, the user has
            // explicitly set the bounds so we don't want to mess with them
            if (scalarDataVariable.GetType() != typeof(RangedScalarDataVariable))
            {
                scalarDataVariable.maxValue = Mathf.Max(scalarDataVariable.maxValue, dataObject.dataset.GetScalarMax(scalarArrayName));
                scalarDataVariable.minValue = Mathf.Min(scalarDataVariable.minValue, dataObject.dataset.GetScalarMin(scalarArrayName));
            }
        }

        foreach (var vectorArrayName in dataObject.dataset.vectorArrayNames)
        {

            IVectorDataVariable vectorDataVariable = ABRManager.Instance.FindNodeForLabel(typeof(IVectorDataVariable), vectorArrayName) as IVectorDataVariable;

            if (vectorDataVariable == null)
            {
                vectorDataVariable = ABRManager.CreateNode<RawVectorDataVariable>();
                (vectorDataVariable as RawVectorDataVariable).VariableName = vectorArrayName;

                ABRManager.Instance.SetNodeLabel(vectorDataVariable, vectorArrayName);
            } 
        }
    }
    

    private IDataObject GetDataObject(string label)
    {
        IDataObject dataObject = ABRManager.Instance.FindNodeForLabel(typeof(IDataObject), label) as IDataObject;

        return dataObject;

    }




    public void RemoveDataObject(DataObject toRemove)
    {

    }
   
    public DataObject AddPlaceholderDataObject(string placeholderLabel)
    {
        return null;
       
    }

   

    private void Awake()
    {

    }






    // Update is called once per frame
    void Update()
    {
        //base.Update();
        // Force Instance to populate when not in threaded mode
        if (Instance == null) { }

        while (updateActions.Count > 0)
        {
            updateActions.Dequeue().Invoke();
        }
    }

    public IAssignable GetNode(Guid guid)
    {
        throw new NotImplementedException();
    }

    public IAssignable GetNode(string label)
    {
        throw new NotImplementedException();
    }
}
