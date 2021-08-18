using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(DeltaMoverManager))]
public class DeltaMoverManagerEditor : Editor
{



    public override void OnInspectorGUI()
    {
        DeltaMoverManager myTarget = (DeltaMoverManager)target;
        foreach (var mover in myTarget.childMovers)
        {
            var temp = GUI.backgroundColor;
            GUI.backgroundColor = mover.color;
            if (GUILayout.Button(mover.transform.name, GUILayout.ExpandWidth(false)))
            {
                Selection.activeGameObject = mover.gameObject;
            }
            GUI.backgroundColor = temp;
            EditorGUILayout.LabelField("Start Position", mover.startTranslate.ToString());

            mover.transform.localPosition = EditorGUILayout.Vector3Field("Position", mover.transform.localPosition);

            var vt = EditorGUILayout.Vector3Field("Delta Position", mover.deltaTranslate);

            mover.SetDeltaTranslate(vt);

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Start Rotation", mover.startRotate.eulerAngles.ToString());

            mover.transform.localEulerAngles = EditorGUILayout.Vector3Field("Rotation", mover.transform.localEulerAngles);
            var vr = EditorGUILayout.Vector3Field("Delta Rotation", mover.deltaRotate);

            mover.SetDeltaRotate(vr);
            //if (Application.isEditor)
             //   EditorUtility.SetDirty(mover);



            EditorGUILayout.Space();
            EditorGUILayout.Space();

        }

        if (GUILayout.Button("Set as start", GUILayout.ExpandWidth(false)))
        {
            myTarget.SetStartState();
        }
        if (GUILayout.Button("Return to start", GUILayout.ExpandWidth(false)))
        {
            myTarget.RestartAnimation();
        }




        EditorGUILayout.Space();


        GUILayout.Label("Camera Settings");
        if (myTarget.camera != null)
            myTarget.camera.fieldOfView = EditorGUILayout.Slider("Field of View", myTarget.camera.fieldOfView, 0, 180);

        EditorGUILayout.Space();


        if (GUILayout.Button(myTarget.IsAnimating() == true ? "Pause" : "Play", GUILayout.ExpandWidth(false)))
        {
            if (myTarget.IsAnimating())
                myTarget.PauseAnimating();
            else
                myTarget.ResumeAnimating();
        }

        if (GUILayout.Button(myTarget.IsRecording() == false ? "Record Animation" : "Stop Recording", GUILayout.ExpandWidth(false)))
        {
            if (myTarget.IsRecording())
            {
                myTarget.StopRecording();
                myTarget.PauseAnimating();
                myTarget.RestartAnimation();
            }
            else
            {
                myTarget.RestartAnimation();
                myTarget.StartRecording();

            }
        }


        myTarget.animateOnPlay = GUILayout.Toggle(myTarget.animateOnPlay, "Animate On Play");





        if (myTarget.animate )
        {
            EditorUtility.SetDirty(myTarget);

        }

        EditorGUILayout.Space();
        EditorGUILayout.Space();

        EditorGUILayout.BeginHorizontal();
        myTarget.saveName = EditorGUILayout.TextField("State Name", myTarget.saveName);
        if (GUILayout.Button("Save", GUILayout.ExpandWidth(false)))
        {
            myTarget.SaveState();
        }

        EditorGUILayout.EndHorizontal();


        foreach (var save in myTarget.saves)
        {
            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Load " + save, GUILayout.ExpandWidth(false)))
            {
                myTarget.LoadState(save);
                myTarget.RestartAnimation();
            }
            if (GUILayout.Button("Show in explorer", GUILayout.ExpandWidth(false)))
            {
                myTarget.ShowState(save);
            }
            if (GUILayout.Button("X", GUILayout.ExpandWidth(false)))
            {
                myTarget.DeleteState(save);
            }
            EditorGUILayout.EndHorizontal();

        }

    }
}

#endif