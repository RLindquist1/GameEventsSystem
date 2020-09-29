using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3IntGameEvent))]
    public class Vector3IntGameEventEditor : TwoArgGameEventEditor<Vector3, int>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, int> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}