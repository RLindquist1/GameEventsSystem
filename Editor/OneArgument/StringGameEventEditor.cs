using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(StringGameEvent))]
    public class StringGameEventEditor : OneArgGameEventEditor<string>
    {
        protected override void FirstArgument(OneArgGameEvent<string> myGameEvent)
        {
            DefaultMessage = EditorGUILayout.TextField(myGameEvent.Default);
        }
    }
}