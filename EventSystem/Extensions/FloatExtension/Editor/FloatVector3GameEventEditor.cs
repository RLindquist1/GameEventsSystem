using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.FloatExtension.Editors
{
    [CustomEditor(typeof(FloatVector3GameEvent))]
    public class FloatVector3GameEventEditor : TwoArgGameEventEditor<float, Vector3>
    {
        protected override void FirstField(TwoArgGameEvent<float, Vector3> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<float, Vector3> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector3Field("", myGameEvent.DefaultU);
        }
    }
}