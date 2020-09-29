using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(TwoVector3GameEvent))]
    public class TwoVector3GameEventEditor : TwoArgGameEventEditor<Vector3, Vector3>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, Vector3> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, Vector3> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector3Field("", myGameEvent.DefaultU);
        }
    }
}