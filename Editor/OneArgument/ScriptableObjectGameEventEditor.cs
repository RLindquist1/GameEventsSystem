using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ScriptableObjectGameEvent))]
    public class ScriptableObjectGameEventEditor : OneArgGameEventEditor<ScriptableObject>
    {
        protected override void FirstArgument(OneArgGameEvent<ScriptableObject> myGameEvent)
        {
            DefaultMessage = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.Default, typeof(ScriptableObject), false);
        }
    }
}