using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(BoolGameEvent))]
    public class BoolGameEventEditor : OneArgGameEventEditor<bool>
    {
        protected override void FirstArgument(OneArgGameEvent<bool> myGameEvent)
        {
            DefaultMessage = EditorGUILayout.Toggle(myGameEvent.Default);
        }
    }
}