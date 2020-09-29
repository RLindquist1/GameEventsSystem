using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.StringExtension.Editors
{
    [CustomEditor(typeof(StringIntGameEvent))]
    public class StringIntGameEventEditor : TwoArgGameEventEditor<string, int>
    {
        protected override void FirstField(TwoArgGameEvent<string, int> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<string, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}