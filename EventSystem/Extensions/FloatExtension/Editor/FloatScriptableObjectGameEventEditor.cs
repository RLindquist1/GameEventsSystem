using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.FloatExtension.Editors
{
    [CustomEditor(typeof(FloatScriptableObjectGameEvent))]
    public class FloatScriptableObjectGameEventEditor : TwoArgGameEventEditor<float, ScriptableObject>
    {
        protected override void FirstField(TwoArgGameEvent<float, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<float, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }
    }
}