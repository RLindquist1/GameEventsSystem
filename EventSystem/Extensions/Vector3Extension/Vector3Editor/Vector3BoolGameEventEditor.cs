using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3BoolGameEvent))]
    public class Vector3BoolGameEventEditor : TwoArgGameEventEditor<Vector3, bool>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, bool> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }
    }
}