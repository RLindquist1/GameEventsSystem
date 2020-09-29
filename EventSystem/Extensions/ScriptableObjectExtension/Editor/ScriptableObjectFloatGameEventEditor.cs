using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.ScriptableObjectExtension.Editors
{
    [CustomEditor(typeof(ScriptableObjectFloatGameEvent))]
    public class ScriptableObjectFloatGameEventEditor : TwoArgGameEventEditor<ScriptableObject, float>
    {
        protected override void FirstField(TwoArgGameEvent<ScriptableObject, float> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<ScriptableObject, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}