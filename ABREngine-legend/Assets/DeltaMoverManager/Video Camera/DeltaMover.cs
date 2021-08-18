using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;

[ExecuteAlways, Serializable]
public class DeltaMover : MonoBehaviour {
    static int colorCounter = 0;
    static Color[] colors = new Color[]{ Color.blue, Color.green, Color.yellow, Color.cyan, Color.magenta };
    [HideInInspector] public Color color;

    [SerializeField]
    public Vector3 deltaTranslate;
    [SerializeField]
    public Vector3 deltaRotate;
    [SerializeField]
     public Vector3 startTranslate;
    [SerializeField]
    public Quaternion startRotate;

    public bool animate;

    public bool saveState;
    public bool resetState;


    public void WriteToStream(StreamWriter writer)
    {


        writer.WriteLine(deltaTranslate.x);
        writer.WriteLine(deltaTranslate.y);
        writer.WriteLine(deltaTranslate.z);

        writer.WriteLine(deltaRotate.x);
        writer.WriteLine(deltaRotate.y);
        writer.WriteLine(deltaRotate.z);

        writer.WriteLine(startTranslate.x);
        writer.WriteLine(startTranslate.y);
        writer.WriteLine(startTranslate.z);

        writer.WriteLine(startRotate.x);
        writer.WriteLine(startRotate.y);
        writer.WriteLine(startRotate.z);
        writer.WriteLine(startRotate.w);


    }

    public void ReadFromStream(StreamReader reader)
    {
        deltaTranslate.x = float.Parse(reader.ReadLine());
        deltaTranslate.y = float.Parse(reader.ReadLine());
        deltaTranslate.z = float.Parse(reader.ReadLine());

        deltaRotate.x = float.Parse(reader.ReadLine());
        deltaRotate.y = float.Parse(reader.ReadLine());
        deltaRotate.z = float.Parse(reader.ReadLine());

        startTranslate.x = float.Parse(reader.ReadLine());
        startTranslate.y = float.Parse(reader.ReadLine());
        startTranslate.z = float.Parse(reader.ReadLine());

        startRotate.x = float.Parse(reader.ReadLine());
        startRotate.y = float.Parse(reader.ReadLine());
        startRotate.z = float.Parse(reader.ReadLine());
        startRotate.w = float.Parse(reader.ReadLine());

 
    }



    // Use this for initialization
    void Awake () {
        startTranslate = transform.localPosition;
        startRotate = transform.localRotation;



        // Just for picking unique colors for each of the delta movers
        int colorIndex = Array.IndexOf(FindObjectsOfType<DeltaMover>(),this);
        color = colors[colorIndex % colors.Length];
        MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

        GetComponent<MeshRenderer>()?.GetPropertyBlock(materialPropertyBlock);
        materialPropertyBlock.SetColor("_Color", color);
        GetComponent<MeshRenderer>()?.SetPropertyBlock(materialPropertyBlock);

    }

    public void SetDeltaRotate(Vector3 delta)
    {
        deltaRotate = delta;
    }
    public void SetDeltaTranslate(Vector3 delta)
    {
        deltaTranslate = delta;
    }
    void OnDrawGizmos()
    {

        float diskRadius = 0.1f;


        Gizmos.color = Color.white;
        if(deltaTranslate.magnitude > 0)
        {
            DrawArrow.ForGizmo(transform.position, transform.rotation* deltaTranslate.normalized*diskRadius*3, color, arrowHeadLength: diskRadius * 0.33f, arrowHeadAngle: 30);
        }
        //Gizmos.matrix = transform.localToWorldMatrix;

        if (deltaRotate.magnitude > 0)
        {
            UnityEditor.Handles.color = color;
            float angle;
            Vector3 axis;
            Quaternion.Euler(deltaRotate).ToAngleAxis(out angle, out axis);
            axis = transform.localToWorldMatrix * axis;
            UnityEditor.Handles.DrawWireDisc(transform.position, axis, diskRadius);
            Vector3 forwardOnRing = Vector3.Cross(Vector3.Cross(transform.forward, axis), axis).normalized;

            DrawArrow.ForGizmo(transform.position + forwardOnRing * diskRadius, Vector3.Cross(axis, forwardOnRing).normalized*0.01f, color,arrowHeadLength:diskRadius*0.33f,arrowHeadAngle:30); ;

        }


    }
    // Update is called once per frame
    void Update () {
        if(saveState)
        {
            startTranslate = transform.localPosition;
            startRotate = transform.localRotation;
            saveState = false;
        }

        if (resetState)
        {
            transform.localPosition = startTranslate;
            transform.localRotation = startRotate;
            resetState = false;
        }

        if(animate)
        {
            transform.localPosition += deltaTranslate * Time.deltaTime;
            transform.localRotation = Quaternion.Euler(deltaRotate * Time.deltaTime)* transform.localRotation;
        }

    }
}

#endif