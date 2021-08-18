using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using IVLab.Utilities.GenericObjectPool;
 

public class ABRDataScene : ABRObject
{
    public DataScene dataScene;

    [ABRInput("Encoding Set", "Encoding Set")]
    EncodingSet encodingSet;


    private const int maxTries = 2000;

    public Dictionary<ABREncoding, EncodedObject> encodedObjects = new Dictionary<ABREncoding, EncodedObject>();

    Dictionary<ABREncoding, EncodingRenderInfo> encodingInfo = new Dictionary<ABREncoding, EncodingRenderInfo>();

    Bounds cachedBounds = new Bounds();
    public ABRDataScene()
    {
        //    if(encodingSet == null)
        //    {

        ABRManager.QueueMainThreadAction(() =>
        {
            GameObject go = new GameObject("Data Scene");

            dataScene = go.AddComponent<DataScene>();
            dataScene.abrDataScene = this;
        });
        
        //}

    }

    public override void Destroy()
    {
        
        dataScene.gameObject.SetActive(false);

        if (ThreadCheck.IsMainThread())
        {
            RemoveAllEncodedObjects();
            GameObject.Destroy(dataScene.gameObject);
        } else
        {
            Debug.LogError("Can't clean up if not on the main thread.");
        }
        base.Destroy();

    }

    void CreateEncodedObject(ABREncoding encoding)
    {
        GameObject go;
        if(encodedObjects.ContainsKey(encoding))
        {
            RemoveEncodedObject(encoding);
        }
        if (encoding.renderingStrategy != null)
        {
            go = GenericObjectPool.Instance.GetObjectFromPool(encoding.renderingStrategy.GetType().Name, dataScene.transform, gg => { });
        }
        else
        {
            go = GenericObjectPool.Instance.GetObjectFromPool("EmptyEncodings", dataScene.transform, _ => { });
        }

        go.transform.localPosition = Vector3.zero;
        go.transform.localRotation = Quaternion.identity;

        go.name = "Encoding for " + "\"" + encoding.renderingStrategy + "\" " + encoding.UniqueID;
        if(go?.GetComponent<EncodedObject>() == null)
            go.AddComponent<EncodedObject>();

        
        go.GetComponent<EncodedObject>().Encoding = encoding;
        go.GetComponent<EncodedObject>().dataScene = this;
        


        encodedObjects[encoding] = go.GetComponent<EncodedObject>();


    }
    void RemoveEncodedObject(ABREncoding encoding)
    {
        if (encodedObjects.ContainsKey(encoding) == false)
        {
            Debug.LogWarning("Encoded object doesn't have encoding so cannot remove it.");
            encoding.Destroy();
            return;
        }

        if (encoding.renderingStrategy != null)
        {
            encoding.renderingStrategy.RecycleEncodedGameObject(encodedObjects[encoding]);
        }
        else
        {
            GenericObjectPool.Instance.ReturnObjectToPool(encodedObjects[encoding].gameObject);
        }
        encodedObjects.Remove(encoding);
    }

    void RemoveAllEncodedObjects()
    {
        foreach(var encodedObject in encodedObjects)
        {
            if (encodedObject.Key.renderingStrategy != null)
            {
                encodedObject.Key.renderingStrategy.RecycleEncodedGameObject(encodedObjects[encodedObject.Key]);
            }
        }
        encodedObjects.Clear();
    }
    void CreateEncodingObjectSet(EncodingSet encodingSet)
    {
        foreach(var encoding in encodingSet)
        {
            CreateEncodedObject(encoding as ABREncoding);
        }
    }

    public void UpdateAllEncodingObjects()
    {
        foreach(var encodedObject in encodedObjects)
        {
            UpdateEncodingObject(encodedObject.Key);
        }
    }
    void UpdateEncodingObject(ABREncoding encoding)
    {
        //Debug.Log("Updating encoding " + encoding.UniqueID);
        Task.Run(() => {
            for (int iteration = 0; iteration < maxTries; iteration++)
            {
                if (encodedObjects.ContainsKey(encoding))
                {
                    encodedObjects[encoding].encodingRenderInfo =
                        encoding?.renderingStrategy?.ComputeEncodingDataForEncodedObject(encodedObjects[encoding]);
                    break;
                }
                else
                {
                    Debug.LogWarning("Encoding not present in encodingObjects. Trying again: iteration " + (iteration + 1));
                }
            }

            ABRManager.QueueMainThreadAction(() =>
            {
                UpdateEncodingObjectMainThread(encoding);
            });

        });
    }

    void UpdateEncodingObjectMainThread(ABREncoding encoding)
    {
        //Debug.Log("Rencoding " + encoding);
        if (encoding?.renderingStrategy == null ) return;
        encoding.renderingStrategy.MakeEncodedGameObject(encodedObjects[encoding]);
    }

    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        if(false)Debug.Log("Datascene receiving message");
        if (message.Type == ABRUpdateMessage.UpdateType.InputChanged)
        {
            if((message.UpdateInfo as ABRUpdateMessage.InputChangedInfo).NewAssignable != null)
            {
                if(false)Debug.Log("Just received an encoding Set");
                ABRManager.QueueMainThreadAction(() =>
                {
                    CreateEncodingObjectSet((message.UpdateInfo as ABRUpdateMessage.InputChangedInfo).NewAssignable as EncodingSet);

                });
            } else
            {
                Debug.Log("Just removed an encoding Set");
                ABRManager.QueueMainThreadAction(() =>
                {
                    RemoveAllEncodedObjects();
                });
            }


        }


        if (message.Type == ABRUpdateMessage.UpdateType.ItemAdded)
        {
            ABRUpdateMessage.ItemInfo itemInfo = message.UpdateInfo as ABRUpdateMessage.ItemInfo;
            Debug.Log("Need to add a new EncodedObject");


            ABRManager.QueueMainThreadAction(() =>
            {
                CreateEncodedObject(itemInfo.Item as ABREncoding);

                if (cachedBounds != GetDataBounds())
                {
                    UpdateAllEncodingObjects();
                }
                else
                {
                    UpdateEncodingObjectMainThread(itemInfo.Item as ABREncoding);
                }

            }); 



        }

        if (message.Type == ABRUpdateMessage.UpdateType.ItemRemoved)
        {
            ABRUpdateMessage.ItemInfo itemInfo = message.UpdateInfo as ABRUpdateMessage.ItemInfo;
            //Debug.Log("Need to remove an EncodedObject");

            ABRManager.QueueMainThreadAction(() =>
            {
                RemoveEncodedObject(itemInfo.Item as ABREncoding);

                //var encoding = itemInfo.Item as Encoding;
                //EncodedObject encodedObject = encodedObjects[encoding];
                //encoding.renderingStrategy?.RecycleEncodedGameObject(encodedObject);


                //encodedObjects[itemInfo.Item as Encoding] = encodedObject;
            });

        }


        if (message.Type == ABRUpdateMessage.UpdateType.ItemUpdated)
        {
            ABRUpdateMessage.ItemUpdatedInfo itemInfo = message.UpdateInfo as ABRUpdateMessage.ItemUpdatedInfo;
            ABREncoding encoding = itemInfo.ItemUpdateMessage.Sender as ABREncoding;
            if(cachedBounds != GetDataBounds())
            {
                UpdateAllEncodingObjects();
            } else
            {
                UpdateEncodingObject(encoding);
            }
            if (false)Debug.Log("Need to re-populate an encoded object");
        }
    }

    public Bounds GetDataBounds()
    {

        bool first = true;
        Bounds combinedBounds = new Bounds();
        foreach(var encodedObject in this.encodedObjects)
        {
            var dataset = encodedObject.Value?.Encoding?.dataObject?.dataset;

            if (first && dataset != null)
            {

                combinedBounds = dataset.bounds;
                first = false;


            }
            else if(dataset != null)
            {
                combinedBounds.Encapsulate(dataset.bounds);
            }
        }

        return combinedBounds;
    }

    public Task ComputeUpdate()
    {
        throw new System.NotImplementedException();
    }

    ///protected override void createO

}
public class DataScene : MonoBehaviour
{
    public ABRDataScene abrDataScene;

    public Bounds GetDataBounds()
    {
        return abrDataScene.GetDataBounds();
    }
    private void Start()
    {
        //if(abrDataScene == null)
        //{
        //    abrDataScene = new ABRDataScene { dataScene = this };
        //}
    }

    EncodingSet _encodingSet;

    public EncodingSet EncodingSet
    {
        get { return _encodingSet; }
        set { _encodingSet = value; }
    }

    List<EncodedObject> encodedObjects;

    public string details;

    // Update is called once per frame
    void LateUpdate()
    {
        details = GetDataBounds().center + " --- " + GetDataBounds().size;
        if(abrDataScene.GetDataBounds().size.magnitude > 0)
        {
            transform.localPosition = -GetDataBounds().center * (1f / GetDataBounds().extents.magnitude);

            transform.localScale = (1f / GetDataBounds().extents.magnitude) * Vector3.one;

        }
    }
}
