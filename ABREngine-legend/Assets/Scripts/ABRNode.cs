using System;
using UnityEngine;

public class ABRInputAttribute : Attribute
{
    public string inputName;
    public string parameterName;
    public string defaultText;
    public string tooltipText;
    public bool advancedOnly;
    public ABRInputAttribute(string inputName, string parameterName, string defaultText = "", string tooltipText = "", bool advancedOnly = false)
    {
        this.inputName = inputName;
        this.parameterName = parameterName;
        this.defaultText = defaultText;
        this.tooltipText = tooltipText;
        this.advancedOnly = advancedOnly;
    }

}

public abstract class ABRNode : IAssignable
{

    //public override string ToString()
    //{
    //    if (Label == "") return base.ToString();
    //    else return base.ToString() + " \"" + Label + "\"";
    //}
    //public ABRNode(string label) { Label = label; }
    public virtual void Destroy()
    {
        IsDestroyed = true;
        SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.Deleted });
    }
    protected bool IsDestroying { get; set; } = false;
    public bool IsDestroyed { get; set; } = false;


    public ABRNode()
    {
        
    }
    Guid _uniqueID = Guid.Empty;
    public virtual bool IsValid { get { return true; } }

    public virtual Guid UniqueID
    {
        get { if (_uniqueID == Guid.Empty) _uniqueID = Guid.NewGuid(); return _uniqueID; }
        set { _uniqueID = value;}
    }

    //public virtual string Label
    //{
    //    get;
    //    set;
    //} = "";

    public void SendUpdateMessage(string message)
    {
        SendUpdateMessage(new ABRUpdateMessage { Message = message, Type = ABRUpdateMessage.UpdateType.Unknown });
    }

    public void SendUpdateMessage(ABRUpdateMessage message)
    {
        message.Sender = this;
        ObserverNode.PassMessage(message);
    }

    ObserverNode _observerNode;
    protected ObserverNode ObserverNode
    {
        get { if (_observerNode == null) _observerNode = new ObserverNode(this, ReceiveMessage); return _observerNode; }
    }

    public abstract void ReceiveMessage(ABRUpdateMessage message);

    protected void Subscribe(ABRNode inputObject, object inputField)
    {
        ObserverNode.SubscribeTo(inputObject?.ObserverNode, inputField);
    }

    static public ABRNode Deserialize(JSONObject json, ABRNode node = null)
    {


        if(node == null)
        {
            if (json.HasField("uuid"))
            {
                var createMethod = typeof(ABRManager).GetMethod("CreateNode", new Type[] { typeof(Type), typeof(Guid) });

                node = (ABRNode)createMethod.Invoke(ABRManager.Instance, (new object[] { Type.GetType(json.GetField("type").str), new Guid(json["uuid"].str) }));
            }
            else
            {
                var createMethod = typeof(ABRManager).GetMethod("CreateNode", new Type[] {typeof(Type)});

                node = (ABRNode)createMethod.Invoke(ABRManager.Instance, new object[] { Type.GetType(json.GetField("type").str) });
            }
        } 
        if(json.HasField("label"))
        {
            ABRManager.Instance.SetNodeLabel(node, json["label"].str);
        }
        node.deserialize(json);
        return node;
    }

    protected virtual void deserialize(JSONObject json)
    {
        
    }
    static public JSONObject Serialize(ABRNode node)
    {
        JSONObject json = new JSONObject();
        json = node.serialize(json);
        return json;
    }

    protected virtual JSONObject serialize(JSONObject json)
    {
        json.AddField("uuid", this.UniqueID.ToString());

        json.AddField("type", this.GetType().FullName);
        if(ABRManager.Instance.GetNodeLabel(this) != "") json.AddField("label", ABRManager.Instance.GetNodeLabel(this));

        return json;
    }
}

