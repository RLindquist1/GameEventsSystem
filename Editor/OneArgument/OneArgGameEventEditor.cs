using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace GameEvents.Editors
{
    public class OneArgGameEventEditor<T> : Editor
    {
        public T DefaultMessage;

        public override void OnInspectorGUI()
        {
            OneArgGameEvent<T> myGameEvent = (OneArgGameEvent<T>)target;

            EditorGUILayout.LabelField("Argument Default (" + typeof(T).ToString() + ")");
            FirstArgument(myGameEvent);
            myGameEvent.Default = DefaultMessage;
            if (GUILayout.Button("Raise Event"))
            {
                myGameEvent.Raise();
            }
        }

        protected virtual void FirstArgument(OneArgGameEvent<T> myGameEvent) { }
    }
}