using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector2Extension.Editors
{
    [CustomEditor(typeof(Vector2StringGameEvent))]
    public class Vector2StringGameEventEditor : TwoArgGameEventEditor<Vector2, string>
    {
        protected override void FirstField(TwoArgGameEvent<Vector2, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector2, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}