using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABRCollection : ABRNode
{
    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        // By default, assume that the observers to this need to know there was an update
        if(false)Debug.Log(this + ": " + "Receiving an observation " + message.Type + "(" + message.UpdateInfo + ") " + " message - " + message.Sender + " says " + message.Message);

        SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ItemUpdated, UpdateInfo = new ABRUpdateMessage.ItemUpdatedInfo { ItemUpdateMessage = message }, Message = this + " had an item update state: " + message.Sender });
    }
}


public class ABRSet : ABRCollection, IEnumerable<ABRNode>
{
    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        // By default, assume that the observers to this need to know there was an update
        if (false) Debug.Log(this + ": " + "Receiving an observation " + message.Type + "(" + message.UpdateInfo + ") " + " message - " + message.Sender + " says " + message.Message);
        
        if (message.Type == ABRUpdateMessage.UpdateType.Deleted)
        {
            Remove(message.Sender);
        } else if(message.Type == ABRUpdateMessage.UpdateType.ItemAdded)
        {
            SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ItemAdded, UpdateInfo = message.UpdateInfo, Message = this + " had an item added: " + message.Sender });

        }
        else if (message.Type == ABRUpdateMessage.UpdateType.ItemRemoved)
        {
            SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ItemRemoved, UpdateInfo = message.UpdateInfo, Message = this + " had an item added: " + message.Sender });

        }

        else
        {
            SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ItemUpdated, UpdateInfo = new ABRUpdateMessage.ItemUpdatedInfo { ItemUpdateMessage = message }, Message = this + " had an item update state: " + message.Sender });

        }
    }

    protected void UnsubscribeFromItem(ABRNode item)
    {
        ObserverNode.Unsubscribe(item);
    }

    protected void SubscribeToItem(ABRNode inputObject)
    {
        Subscribe(inputObject, inputObject);
    }



    HashSet<ABRNode> abrNodes = new HashSet<ABRNode>();

    public void Add(ABRNode item)
    {
        SubscribeToItem(item);
        abrNodes.Add(item);
        ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ItemAdded, UpdateInfo =  new ABRUpdateMessage.ItemInfo { Item  = item }, Message = "Added an item:" + item });
    }

    public void Remove(ABRNode item)
    {
        UnsubscribeFromItem(item);
        abrNodes.Remove(item);
        ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.ItemRemoved, UpdateInfo = new ABRUpdateMessage.ItemInfo { Item = item }, Message = "Added an item:" + item });

    }


    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
        JSONObject items = JSONObject.Create(JSONObject.Type.ARRAY);
        foreach(var item in abrNodes)
        {
            items.Add(item?.UniqueID.ToString() ?? "null");
        }
        json.AddField("items", items);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        JSONObject inputs = json.GetField("items");
        foreach (var input in inputs.list)
        {
            ABRManager.Instance.AddItemFromGuid(this, new Guid(input.str));
        }

    }


    public IEnumerator<ABRNode> GetEnumerator()
    {
        return ((IEnumerable<ABRNode>)abrNodes).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<ABRNode>)abrNodes).GetEnumerator();
    }
}