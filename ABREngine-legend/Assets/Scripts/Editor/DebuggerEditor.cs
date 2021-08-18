using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.Linq;

[CustomEditor(typeof(Debugger))]
public class DebuggerEditor : Editor
{
    private Debugger script;

    public IEnumerable<Type> FindDerivedTypes(Assembly assembly, Type baseType)
    {
        return assembly.GetTypes().Where(t => baseType.IsAssignableFrom(t) && t.IsAbstract == false && t.IsGenericTypeDefinition == false);
    }

    string[] creatableTypes;
    private void OnEnable()
    {
        script = (Debugger)serializedObject.targetObject;
        creatableTypes = FindDerivedTypes(Assembly.GetExecutingAssembly(), typeof(ABRNode)).Select(a => a.FullName).ToArray();
    }

    int selectedTypeIndex = 0;
    string label = "";

    ABRNode selectedNode = null;
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        selectedTypeIndex = EditorGUILayout.Popup("Type", selectedTypeIndex, creatableTypes);

        label = EditorGUILayout.TextField("Label", label);

        if (GUILayout.Button("Create " + creatableTypes[selectedTypeIndex]))
        {
            selectedNode = ABRManager.CreateNode(Type.GetType(creatableTypes[selectedTypeIndex]));
        }

        GUILayout.Space(20);

        EditorGUILayout.LabelField("Selected node: " + selectedNode);
    }
}
