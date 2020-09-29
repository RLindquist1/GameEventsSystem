using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace GameEvents.Editors
{
    public class TwoArgGameEventEditor<T, U> : Editor
    {
        protected T DefaultMessageT;
        protected U DefaultMessageU;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            TwoArgGameEvent<T, U> myGameEvent = (TwoArgGameEvent<T, U>)target;


            GUILayout.BeginHorizontal();

            GUILayout.BeginVertical();
            EditorGUILayout.LabelField("First Argument Default (" + typeof(T).ToString() + ")");
            FirstField(myGameEvent);
            myGameEvent.DefaultT = DefaultMessageT;
            GUILayout.EndVertical();

            GUILayout.BeginVertical();
            EditorGUILayout.LabelField("Second Argument Default (" + typeof(U).ToString() + ")");
            SecondField(myGameEvent);
            myGameEvent.DefaultU = DefaultMessageU;
            GUILayout.EndVertical();

            GUILayout.EndHorizontal();

            if (GUILayout.Button("Raise Event"))
            {
                myGameEvent.Raise();
            }
        }

        protected virtual void FirstField(TwoArgGameEvent<T, U> myGameEvent) { }
        protected virtual void SecondField(TwoArgGameEvent<T, U> myGameEvent) { }
    }
}