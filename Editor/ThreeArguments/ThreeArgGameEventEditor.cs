using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
namespace GameEvents.Editors
{
    public class ThreeArgGameEventEditor<T, U, V> : Editor
    {
        protected T DefaultMessageT;
        protected U DefaultMessageU;
        protected V DefaultMessageV;

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            ThreeArgGameEvent<T, U, V> myGameEvent = (ThreeArgGameEvent<T, U, V>)target;


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

            GUILayout.BeginVertical();
            EditorGUILayout.LabelField("Third Argument Default (" + typeof(V).ToString() + ")");
            ThirdField(myGameEvent);
            myGameEvent.DefaultV = DefaultMessageV;
            GUILayout.EndVertical();



            if (GUILayout.Button("Raise Event"))
            {
                myGameEvent.Raise();
            }
        }

        protected virtual void FirstField(ThreeArgGameEvent<T, U, V> myGameEvent) { }
        protected virtual void SecondField(ThreeArgGameEvent<T, U, V> myGameEvent) { }
        protected virtual void ThirdField(ThreeArgGameEvent<T, U, V> myGameEvent) { }
    }
}