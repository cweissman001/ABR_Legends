using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDataObject : IAssignable
{
    Dataset dataset { get; set; }
}
public class DataObject : ABRObject, IDataObject
{
    public Dataset dataset { get; set; }

}