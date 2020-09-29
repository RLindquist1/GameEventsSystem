using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3StringGameEvent))]
    public class Vector3StringGameEventEditor : TwoArgGameEventEditor<Vector3, string>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}