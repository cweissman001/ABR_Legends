using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ParaviewDataListener))]
public class ParaviewDataListenerEditor : Editor
{
    private ParaviewDataListener script;

    [SerializeField]

    private void OnEnable()
    {
        script = (ParaviewDataListener)serializedObject.targetObject;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (script.listener == null)
        {
            GUILayout.Label("Listener is off.");
            if (GUILayout.Button("Start Server"))
            {
                script.StartServer();
            }
        }
        else
        {
            GUILayout.Label("Listener is listening.");
            if (GUILayout.Button("Stop Server"))
            {
                script.StopServer();
            }
        }


    }
}
