using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.StringExtension.Editors
{
    [CustomEditor(typeof(StringScriptableObjectGameEvent))]
    public class StringScriptableObjectGameEventEditor : TwoArgGameEventEditor<string, ScriptableObject>
    {
        protected override void FirstField(TwoArgGameEvent<string, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<string, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }
    }
}