using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3Vector2GameEvent))]
    public class Vector3Vector2GameEventEditor : TwoArgGameEventEditor<Vector3, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, Vector2> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}