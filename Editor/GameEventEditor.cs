using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            GameEvent myGameEvent = (GameEvent)target;

            if (GUILayout.Button("Raise Event"))
            {
                myGameEvent.Raise();
            }
        }
    }
}