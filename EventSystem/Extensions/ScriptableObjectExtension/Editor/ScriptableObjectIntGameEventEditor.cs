using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.ScriptableObjectExtension.Editors
{
    [CustomEditor(typeof(ScriptableObjectIntGameEvent))]
    public class ScriptableObjectIntGameEventEditor : TwoArgGameEventEditor<ScriptableObject, int>
    {
        protected override void FirstField(TwoArgGameEvent<ScriptableObject, int> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<ScriptableObject, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}