using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.ScriptableObjectExtension.Editors
{
    [CustomEditor(typeof(ScriptableObjectBoolGameEvent))]
    public class ScriptableObjectBoolGameEventEditor : TwoArgGameEventEditor<ScriptableObject, bool>
    {
        protected override void FirstField(TwoArgGameEvent<ScriptableObject, bool> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<ScriptableObject, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }
    }
}