using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;


public class ABRObject : ABRNode
{



    ABRInputIndexerModule _inputIndex = null;
    protected ABRInputIndexerModule InputIndexer
    {
        get { if (_inputIndex == null) _inputIndex = new ABRInputIndexerModule(this); return _inputIndex; }
    }



    //// InputIndexer Pass-throughs
    public string[] InputNames
    {
        get { return InputIndexer.InputNames; }
    }

    public int InputCount
    {
        get { return InputNames.Length; }
    }

    public string GetInputName(int inputIndex)
    {
        return InputNames[inputIndex];
    }

    public int GetInputIndex(string inputName)
    {
        return InputIndexer.GetInputIndex(inputName);
    }

    public IAssignable GetInputValue(int inputIndex)
    {
        return InputIndexer.GetInputValue(inputIndex);
    }

    public IAssignable GetInputValue(string inputName)
    {
        return InputIndexer.GetInputValue(inputName);
    }

    public Type GetInputType(int inputIndex)
    {
        return InputIndexer.GetInputType(inputIndex);
    }

    public Type GetInputType(string inputName)
    {
        return InputIndexer.GetInputType(inputName);
    }

    public bool CanAssignInput(int inputIndex, IAssignable value)
    {
        return InputIndexer.CanAssignInput(inputIndex, value);
    }

    public bool CanAssignInput(string inputName, IAssignable value)
    {
        return InputIndexer.CanAssignInput(inputName, value);
    }

    public void AssignInput(int inputIndex, IAssignable value)
    {
        InputIndexer.AssignInput(inputIndex, value);
    }

    public void AssignInput(string inputName, IAssignable value)
    {
        InputIndexer.AssignInput(inputName, value);
    }


    //// OBSERVER PATTERN CODE
    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        // By default, assume that the observers to this need to know there was an update
        if(false)Debug.Log(this + ": " +
            "Receiving an observation " + message.Type +
            "(" + ((message.Type == ABRUpdateMessage.UpdateType.InputChanged) ? ((message.UpdateInfo as ABRUpdateMessage.InputChangedInfo).InputField.Name) : "...") + ") " +
            " message - " + message.Sender + " says " + message.Message);
        if (message.Type == ABRUpdateMessage.UpdateType.Deleted)
        {
            for(int i = 0; i < InputCount; i++)
            {
                if (GetInputValue(i) == message.Sender)
                {
                    AssignInput(i, null);
                }
            }
        } 
        SendUpdateMessage(message.Sender + " updated its state");
    }

    public void UnsubscribeField(FieldInfo inputField)
    {
        ObserverNode.Unsubscribe(inputField);
    }

    public void SubscribeTo(ABRNode inputObject, FieldInfo inputField)
    {
        Subscribe(inputObject, inputField);
    }

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
        JSONObject inputs = JSONObject.Create(JSONObject.Type.OBJECT);
        for(int i = 0; i < InputCount; i++)
        {
            if (GetInputValue(i) == null)
            {
                inputs.AddField(InputNames[i], JSONObject.nullJO);
            } 
            else
            {
                inputs.AddField(InputNames[i], GetInputValue(i).UniqueID.ToString());

            }
        }
        json.AddField("inputs", inputs);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        JSONObject inputs = json.GetField("inputs");
        foreach(var input in inputs.keys)
        {
            //Debug.Log(input + " : " + inputs[input].str);
            if(inputs[input].IsNull == false)
                ABRManager.Instance.AssignInputFromGuid(this, input, new Guid(inputs[input].str));

        }
        
    }



}

