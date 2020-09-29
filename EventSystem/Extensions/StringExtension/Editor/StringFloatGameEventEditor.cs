using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.StringExtension.Editors
{
    [CustomEditor(typeof(StringFloatGameEvent))]
    public class StringFloatGameEventEditor : TwoArgGameEventEditor<string, float>
    {
        protected override void FirstField(TwoArgGameEvent<string, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<string, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}