using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISourceable
{

}

public interface IAssignable
{
    Guid UniqueID { get; }
    bool IsValid { get; }
}

public interface IAssignable<T> : IAssignable
{
    T value { get; }
}


// Interfaces to distinguish visasset inputs from variable inputs
public interface IUIVisAssetInput {}
public interface IUIVariableInput {}


public interface IFloatMap : IAssignable, ISourceable
{
    float floatVal { get; }
}

public interface IBoolMap : IAssignable, ISourceable
{
    bool boolVal { get; }
}

public interface IInterfaceForInt : IAssignable
{

    int intVal { get; }
}


public class RealNumber : ABRObject, IFloatMap, IUIVisAssetInput
{
    public float _val;

    public float floatVal {
        get { return _val; }

        set {
            _val = value;
            ReceiveMessage(new ABRUpdateMessage { Message = "Float changed", Type = ABRUpdateMessage.UpdateType.InputChanged});
        }
    }

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
       
        json.AddField(nameof(floatVal), floatVal);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        floatVal = json.GetField(nameof(floatVal))?.f ?? 0.0f;

    }
}

public class Checkbox : ABRObject, IBoolMap, IUIVisAssetInput
{
    public bool _val;

    public bool boolVal {
        get { return _val; }

        set {
            _val = value;
            ReceiveMessage(new ABRUpdateMessage { Message = "bool changed", Type = ABRUpdateMessage.UpdateType.InputChanged});
        }
    }

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
       
        json.AddField(nameof(boolVal), boolVal);
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        boolVal = json.GetField(nameof(boolVal))?.b ?? false;
    }
}

public class ColorSource : ABRObject, IColormap
{
    public ColorSource() { this.Color = Color.white; }
    public ColorSource(Color initialColor)  { this.Color = initialColor; }
    public Color Color { get { return color; } set { 
            
            color = value;

            if (colormap == null)
            {
                colormap = new Texture2D(1, 1);
            }
            colormap.SetPixel(0, 0, color);
        }
    }
    Color color;

    protected override JSONObject serialize(JSONObject json)
    {
        json = base.serialize(json);
        json.AddField("color", ColorUtility.ToHtmlStringRGBA(Color));
        return json;
    }

    protected override void deserialize(JSONObject json)
    {
        base.deserialize(json);
        Color c;

        ColorUtility.TryParseHtmlString(json["color"].str, out c);
        Color = c;

    }

    public Color GetColorInterp(float interpAmount)
    {
        return Color;
    }

    Texture2D colormap;
    public Texture2D GetColorGradient()
    {
        
        return colormap;
    }
}

public class StringSource : ABRObject, IAssignable<string>
{
    public StringSource(string initialString) { this.String = initialString; }

    public string String { get; set; }

    string IAssignable<string>.value { get { return String; } }
}
