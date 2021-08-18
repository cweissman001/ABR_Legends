using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public interface IDataVariable : IAssignable
{
    // string VariableName
    // {
    //     get;
    // }
}


public interface IScalarDataVariable : IDataVariable, IUIVariableInput
{
    float minValue { get; set; } 
    float maxValue { get; set; }

    float GetScalarMax();
    float GetScalarMin();
    float GetScaleFactor();
    float GetScaleOffset();
    float[] GetScalarArray(Dataset dataset);

}

public interface IVectorDataVariable : IDataVariable, IUIVariableInput
{
    //bool IsValid();
    Vector3[] GetVectorArray(Dataset dataset);
}

public abstract class RawDataVariable : ABRObject, IDataVariable, IUnsavable
{

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);

        json.AddField("variableName", VariableName);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);

        VariableName = json.GetField("variableName").str;

    }



    public string VariableName
    {
        get;
        set;
    }
}
public class RawVectorDataVariable : RawDataVariable, IVectorDataVariable
{
    public Vector3[] GetVectorArray(Dataset dataset)
    {
        return dataset.GetVectorArray(VariableName);
    }
}

public class AliasAssignable<I> : ABRObject where I : IAssignable
{
    [ABRInput("Label Mapper", "")]
    public readonly IAliasMapper<I> mapper;

    string _aliasLabel;
    public string AliasLabel { 
        get { return _aliasLabel; }
        set
        {
            _aliasLabel = value;
            ReceiveMessage(new ABRUpdateMessage
            {
                Sender = this,
                Type = ABRUpdateMessage.UpdateType.Unknown,
                Message = "alias label changed to " + value
            });
        }
    }

    

    public override bool IsValid { get { if (ABRManager.IsValidNode(mapper) && mapper.GetMappedNode(AliasLabel) != null) return true; else return false; } }

    protected I GetTargetNode()
    {
        if (ABRManager.IsValidNode(mapper))
            return mapper.GetMappedNode(AliasLabel);
        else
            return default;
    }

    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        if(message.Type == ABRUpdateMessage.UpdateType.LabelSet)
        {
            var labels = (message.UpdateInfo as ABRUpdateMessage.LabelSetInfo).LabelSet;
            
            if (labels.Contains(AliasLabel))
            {
                SendUpdateMessage(new ABRUpdateMessage { 
                    Type = ABRUpdateMessage.UpdateType.Unknown
                });

            }
        }
        
        // By default, assume that the observers to this need to know there was an update
        

    }


}


public class AliasScalarDataVariable : AliasAssignable<IScalarDataVariable>, IScalarDataVariable 
{
    public float minValue { get { return GetTargetNode()?.minValue ?? float.MaxValue; } set{ } } 
    public float maxValue { get { return GetTargetNode()?.maxValue ?? float.MinValue; } set { } }

    public string VariableName
    {
        get { return AliasLabel; }
    }

    public float GetScalarMax()
    {
        return maxValue;
    }

    public float GetScalarMin()
    {
        return minValue;
    }

    public float GetScaleFactor()
    {
        return GetTargetNode()?.GetScaleFactor() ?? 1;
    }
    public float GetScaleOffset()
    {
        return GetTargetNode()?.GetScaleFactor() ?? 0;
    }

    public float[] GetScalarArray(Dataset dataset)
    {
        return GetTargetNode()?.GetScalarArray(dataset);// dataset.GetScalarArray(VariableName);
    }

}

public class RangedScalarDataVariable : ABRObject, IScalarDataVariable, IUIVariableInput
{

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
        json.AddField("minValue", minValue);
        json.AddField("maxValue", maxValue);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        minValue = json.GetField("minValue").f;
        maxValue = json.GetField("maxValue").f;

    }

    [ABRInput("InputVariable", "InputVariable")]
    IScalarDataVariable inputVariable;

    public override string ToString()
    {
        return base.ToString() + " (" + minValue + ", " + maxValue + ")";
    }
    public float minValue { get; set; } = float.MaxValue;
    public float maxValue { get; set; } = float.MinValue;
    public float GetScalarMax()
    {
        return maxValue;
    }

    public float GetScalarMin()
    {
        return minValue;
    }

    public float GetScaleFactor()
    {
        if (ABRManager.IsValidNode(inputVariable))
        {
            return inputVariable.GetScaleFactor();
        }
        else
        {
            return 1.0f;
        }
    }
    public float GetScaleOffset()
    {
        if (ABRManager.IsValidNode(inputVariable))
        {
            return inputVariable.GetScaleFactor();
        }
        else
        {
            return 0.0f;
        }
    }

    public float[] GetScalarArray(Dataset dataset)
    {
        if (ABRManager.IsValidNode(inputVariable))
        {
            return inputVariable.GetScalarArray(dataset);
        }
        else
        {
            return null;
        }
    }
}

public class RawScalarDataVariable :  RawDataVariable, IScalarDataVariable
{

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
        json.AddField("minValue", minValue);
        json.AddField("maxValue", maxValue);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        minValue = json.GetField("minValue").f;
        maxValue = json.GetField("maxValue").f;

    }


    public override string ToString()
    {
        return base.ToString() + " (" + minValue + ", " + maxValue + ")";
    }
    public float minValue { get; set; } = float.MaxValue;
    public float maxValue { get; set; } = float.MinValue;
    public float GetScalarMax()
    {
        return maxValue;
    }

    public float GetScalarMin()
    {
        return minValue;
    }

    public float GetScaleFactor()
    {
        return 1;
    }
    public float GetScaleOffset()
    {
        return 0;
    }

    public float[] GetScalarArray(Dataset dataset)
    {
        return dataset.GetScalarArray(VariableName);
    }
}

[System.Serializable]
public class SerializableFloatArray
{
    [SerializeField]
    public float[] array;
}
[System.Serializable]
public class SerializableVectorArray
{
    [SerializeField]
    public Vector3[] array;
}



[System.Serializable]
public class Dataset
{

    [SerializeField]
    public Vector3[] vertexArray;

    [SerializeField]
    public SerializableVectorArray[] vectorArrays;

    [SerializeField]
    public string[] vectorArrayNames;

    [SerializeField]
    public SerializableFloatArray[] scalarArrays;

    [SerializeField]
    public string[] scalarArrayNames;


    [SerializeField]
    public float[] scalarMins;

    [SerializeField]
    public float[] scalarMaxes;

    [SerializeField]
    public int[] indexArray;

    [SerializeField]
    public int[] cellIndexOffsets;

    [SerializeField]
    public int[] cellIndexCounts;

    [SerializeField]
    public Bounds bounds;

    [SerializeField]
    public MeshTopology meshTopology = MeshTopology.Points;

    private Dictionary<string, int> _vectorDictionary;
    private Dictionary<string, int> vectorDictionary
    {
        get
        {
            if (_vectorDictionary == null)
            {
                _vectorDictionary = new Dictionary<string, int>();
                for (int i = 0; i < vectorArrayNames.Length; i++)
                {
                    _vectorDictionary[vectorArrayNames[i]] = i;
                }
            }
            return _vectorDictionary;

        }
    }


    public Vector3[] GetVectorArray(string name)
    {
        int index;

        if (vectorDictionary.TryGetValue(name, out index))
            return vectorArrays?[index].array;
        else return null;
    }



    private Dictionary<string, int> _scalarDictionary;
    private Dictionary<string, int> scalarDictionary
    {
        get
        {
            if (_scalarDictionary == null || _scalarDictionary.Count != scalarArrayNames.Length)
            {
                _scalarDictionary = new Dictionary<string, int>();
                for (int i = 0; i < scalarArrayNames.Length; i++)
                {
                    _scalarDictionary[scalarArrayNames[i]] = i;
                }
            }
            return _scalarDictionary;

        }
    }


    public float[] GetScalarArray(string name)
    {

        int index;

        if (scalarDictionary.TryGetValue(name, out index))
            return scalarArrays[index].array;
        else
            return null;

    }
    public float GetScalarMin(string name)
    {
        int index;
        scalarDictionary.TryGetValue(name, out index);
        return scalarMins[index];
    }

    public float GetScalarMax(string name)
    {
        int index;
        scalarDictionary.TryGetValue(name, out index);
        return scalarMaxes[index];
    }
}
