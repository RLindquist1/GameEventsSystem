using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3FloatGameEvent))]
    public class Vector3FloatGameEventEditor : TwoArgGameEventEditor<Vector3, float>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}