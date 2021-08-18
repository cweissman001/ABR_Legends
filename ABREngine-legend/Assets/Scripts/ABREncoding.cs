using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;


public class ABREncoding : ABRObject, IABRComputable
{

    [ABRInput("Data Object", "Data Object")]
    public readonly IDataObject dataObject;

    [ABRInput("Rendering Strategy", "Rendering Strategy")]
    public readonly IEncodingRenderStrategy renderingStrategy;

    //public Dictionary<EncodedObject, EncodingRenderInfo> renderInfoPerEncodedObject = new Dictionary<EncodedObject, EncodingRenderInfo>();
    public DataObjectRenderInfo dataObjectRenderInfo
    {
        get;
        private set;
    }


    public bool NeedsUpdate { get; set; }

    public bool IsUpdating { get; set; }
    public static object ASCII { get; internal set; }

    public Task ComputeUpdate()
    {
        return Task.Run(() =>
        {
            if (NeedsUpdate)
            {
                if(false)Debug.Log("Beginning ComputeUpdate");
                NeedsUpdate = false;
                IsUpdating = true;

                try
                {
                    RecomputeDataObjectInfo();

                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }


                //ABRManager.QueueMainThreadAction(() =>
                //{
                //    renderingStrategy?.value.MakeEncodedGameObject()
                //});
                

                IsUpdating = false;

                if(false)Debug.Log("Ending ComputeUpdate");

                SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ComputeUpdateFinished, Message = " computed its state" });

            }


        });
    }

    public void RecomputeDataObjectInfo()
    {
        dataObjectRenderInfo = renderingStrategy?.ComputeDataForDataObject(dataObject);
    }


    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        if (message.Type == ABRUpdateMessage.UpdateType.Deleted)
        {
            if(message.Sender == renderingStrategy)
            {
                AssignInput("Rendering Strategy", null);
            }

        }

        NeedsUpdate = true;
        SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.InputChanged, Message = "Something in this Encoding Changed."});

    }

}