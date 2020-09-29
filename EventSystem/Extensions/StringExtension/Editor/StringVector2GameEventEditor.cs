using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.StringExtension.Editors
{
    [CustomEditor(typeof(StringVector2GameEvent))]
    public class StringVector2GameEventEditor : TwoArgGameEventEditor<string, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<string, Vector2> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<string, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}