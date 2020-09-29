using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.StringExtension.Editors
{
    [CustomEditor(typeof(StringBoolGameEvent))]
    public class StringBoolGameEventEditor : TwoArgGameEventEditor<string, bool>
    {
        protected override void FirstField(TwoArgGameEvent<string, bool> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<string, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }

    }
}