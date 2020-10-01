using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeScriptableObjectGameEvent))]
    public class ThreeScriptableObjectGameEventEditor : ThreeArgGameEventEditor<ScriptableObject, ScriptableObject, ScriptableObject>
    {
        protected override void FirstField(ThreeArgGameEvent<ScriptableObject, ScriptableObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(ThreeArgGameEvent<ScriptableObject, ScriptableObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }

        protected override void ThirdField(ThreeArgGameEvent<ScriptableObject, ScriptableObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageV = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultV, typeof(ScriptableObject), false);
        }
    }
}