using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeVector3GameEvent))]
    public class ThreeVector3GameEventEditor : ThreeArgGameEventEditor<Vector3, Vector3, Vector3>
    {
        protected override void FirstField(ThreeArgGameEvent<Vector3, Vector3, Vector3> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(ThreeArgGameEvent<Vector3, Vector3, Vector3> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector3Field("", myGameEvent.DefaultU);
        }

        protected override void ThirdField(ThreeArgGameEvent<Vector3, Vector3, Vector3> myGameEvent)
        {
            DefaultMessageV = EditorGUILayout.Vector3Field("", myGameEvent.DefaultV);
        }
    }
}