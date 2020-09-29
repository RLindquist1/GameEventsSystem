using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.IntExtension.Editors
{
    [CustomEditor(typeof(IntVector3GameEvent))]
    public class IntVector3GameEventEditor : TwoArgGameEventEditor<int, Vector3>
    {
        protected override void FirstField(TwoArgGameEvent<int, Vector3> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<int, Vector3> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector3Field("", myGameEvent.DefaultU);
        }
    }
}