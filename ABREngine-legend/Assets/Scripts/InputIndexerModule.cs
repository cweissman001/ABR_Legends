using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class ABRInputIndexerModule
{
    ABRObject targetObject = null;

    public ABRInputIndexerModule(ABRObject target)
    {
        this.targetObject = target;
    }

    FieldInfo[] _abrInputFields = null;
    Dictionary<string, int> _abrInputIndicesByName = null;
    string[] _abrInputNames = null;



    static BindingFlags bindingFlags = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public;
    protected static FieldInfo[] GetABRInputFields(object target)
    {
        return target.GetType().GetFields(bindingFlags).Where(field => field.GetCustomAttribute<ABRInputAttribute>() != null && typeof(IAssignable).IsAssignableFrom(field.FieldType)).ToArray();
    }

    protected static string[] CatalogABRInputNames(FieldInfo[] abrInputs)
    {
        string[] inputNames = new string[abrInputs.Length];
        for (int i = 0; i < abrInputs.Length; i++)
        {
            inputNames[i] = abrInputs[i].GetCustomAttribute<ABRInputAttribute>().inputName;
        }
        return inputNames;
    }
    protected static Dictionary<string, int> IndexABRInputsByName(FieldInfo[] abrInputs)
    {
        Dictionary<string, int> abrInputIndicesByName = new Dictionary<string, int>();

        for (int i = 0; i < abrInputs.Length; i++)
        {
            abrInputIndicesByName[abrInputs[i].GetCustomAttribute<ABRInputAttribute>().inputName] = i;
        }

        return abrInputIndicesByName;
    }


    protected FieldInfo[] ABRInputFields
    {
        get { if (_abrInputFields == null) _abrInputFields = GetABRInputFields(targetObject); return _abrInputFields; }
    }

    protected Dictionary<string, int> ABRInputIndicesByName
    {
        get { if (_abrInputIndicesByName == null) _abrInputIndicesByName = IndexABRInputsByName(ABRInputFields); return _abrInputIndicesByName; }
    }


    public FieldInfo GetInputField(int inputIndex)
    {
        if (inputIndex >= 0)
            return ABRInputFields[inputIndex];
        else
            return null;
    }
    public FieldInfo GetInputField(string inputName)
    {
        int index = GetInputIndex(inputName);
        return GetInputField(index);
    }

    protected void AssignInput(FieldInfo inputField, IAssignable value)
    {
        if (inputField == null) return;
        IAssignable oldValue = inputField?.GetValue(targetObject) as IAssignable;
        targetObject.UnsubscribeField(inputField);
        inputField?.SetValue(targetObject, value);

        targetObject.SubscribeTo(value as ABRNode, inputField);
        targetObject.ReceiveMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.InputChanged, UpdateInfo = new ABRUpdateMessage.InputChangedInfo { InputField = inputField, OldAssignable = oldValue, NewAssignable = value }, Message = "Updated the field " + inputField.Name + " to " + value });
        //targetObject.SendUpdateMessage(new ABRUpdateMessage { Type = ABRUpdateMessage.UpdateType.InputChanged, UpdateInfo = new ABRUpdateMessage.InputChangedInfo { InputField = inputField, OldAssignable = oldValue, NewAssignable = value }, Message = "Updated the field " + inputField.Name + " to " + value });
    }


    public string[] InputNames
    {
        get
        {
            if (_abrInputNames == null)
            {
                _abrInputNames = CatalogABRInputNames(ABRInputFields);
            }
            return _abrInputNames;
        }
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
        int index;
        if (ABRInputIndicesByName.TryGetValue(inputName, out index) == false) index = -1;

        return index;
    }


    public IAssignable GetInputValue(int inputIndex)
    {
        return GetInputField(inputIndex)?.GetValue(targetObject) as IAssignable;
    }

    public IAssignable GetInputValue(string inputName)
    {
        return GetInputField(inputName)?.GetValue(targetObject) as IAssignable;
    }


    public Type GetInputType(int inputIndex)
    {
        var field = GetInputField(inputIndex);
        var fieldType = field?.FieldType;
        return fieldType;
    }

    public Type GetInputType(string inputName)
    {
        return GetInputField(inputName)?.FieldType;
    }

    public bool CanAssignInput(int inputIndex, IAssignable value)
    {
        return GetInputField(inputIndex)?.FieldType.IsAssignableFrom(value.GetType()) ?? false;
    }

    public bool CanAssignInput(string inputName, IAssignable value)
    {
        return GetInputField(inputName)?.FieldType.IsAssignableFrom(value.GetType()) ?? false;
    }


    public void AssignInput(int inputIndex, IAssignable value)
    {
        //ABRManager.Instance.RegisterInputAssignment(targetObject, inputIndex);
        AssignInput(GetInputField(inputIndex),value);
    }


    public void AssignInput(string inputName, IAssignable value)
    {
        AssignInput(GetInputIndex(inputName), value);
    }

}


