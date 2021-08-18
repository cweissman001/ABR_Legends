using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface DataObjectRenderInfo
{
}
public interface EncodingRenderInfo
{
}

public interface IEncodingRenderStrategy : IAssignable
{
    DataObjectRenderInfo ComputeDataForDataObject(IDataObject dataObject);
    EncodingRenderInfo ComputeEncodingDataForEncodedObject(EncodedObject encodedObject);
    EncodedObject MakeEncodedGameObject(EncodedObject currentGameObject);
    void RecycleEncodedGameObject(EncodedObject encoded);
}

public class EncodingStrategyAttribute : System.Attribute
{
    public enum DataType
    {
        Point,
        Line,
        Surface,
        Volume
    };
    public string StrategyName { get; set; }
    public DataType TopologyType { get; set; }

    public EncodingStrategyAttribute(string strategyName, DataType dataType)
    {
        StrategyName = strategyName;
        TopologyType = dataType;
    }
}
public class EncodingRenderStrategy : ABRObject, IAssignable, IEncodingRenderStrategy
{
    public virtual bool Hidden { get; set; }

    public virtual DataObjectRenderInfo ComputeDataForDataObject(IDataObject dataObject)
    {
        return null;
    }

    public virtual EncodingRenderInfo ComputeEncodingDataForEncodedObject(EncodedObject encodedObject)
    {
        return null;
    }

    public virtual EncodedObject MakeEncodedGameObject(EncodedObject currentGameObject)
    {
        //MeshFilter filter;
        //while ( (filter = currentGameObject.GetComponentInChildren<MeshFilter>()) != null)
        //{
        //    GenericObjectPool.instance.ReturnObjectToPool(nameof(MeshFilter), filter.gameObject);
        //}


        return currentGameObject;
    }

    public virtual void RecycleEncodedGameObject(EncodedObject encoded)
    {

    }

}
