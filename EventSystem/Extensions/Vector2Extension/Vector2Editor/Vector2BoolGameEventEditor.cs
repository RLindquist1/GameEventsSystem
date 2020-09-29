using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector2Extension.Editors
{
    [CustomEditor(typeof(Vector2BoolGameEvent))]
    public class Vector2BoolGameEventEditor : TwoArgGameEventEditor<Vector2, bool>
    {
        protected override void FirstField(TwoArgGameEvent<Vector2, bool> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector2, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }
    }
}