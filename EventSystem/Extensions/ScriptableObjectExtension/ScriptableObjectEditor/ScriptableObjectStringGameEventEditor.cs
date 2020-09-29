using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.ScriptableObjectExtension.Editors
{
    [CustomEditor(typeof(ScriptableObjectStringGameEvent))]
    public class ScriptableObjectStringGameEventEditor : TwoArgGameEventEditor<ScriptableObject, string>
    {
        protected override void FirstField(TwoArgGameEvent<ScriptableObject, string> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<ScriptableObject, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}