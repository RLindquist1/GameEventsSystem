using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(TwoScriptableObjectGameEvent))]
    public class TwoScriptableObjectGameEventEditor : TwoArgGameEventEditor<ScriptableObject, ScriptableObject>
    {
        protected override void FirstField(TwoArgGameEvent<ScriptableObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<ScriptableObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }
    }
}