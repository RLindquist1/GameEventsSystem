using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector2Extension.Editors
{
    [CustomEditor(typeof(Vector2Vector3GameEvent))]
    public class Vector2Vector3GameEventEditor : TwoArgGameEventEditor<Vector2, Vector3>
    {
        protected override void FirstField(TwoArgGameEvent<Vector2, Vector3> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector2, Vector3> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector3Field("", myGameEvent.DefaultU);
        }
    }
}