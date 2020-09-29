using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(IntGameEvent))]
    public class IntGameEventEditor : OneArgGameEventEditor<int>
    {
        protected override void FirstArgument(OneArgGameEvent<int> myGameEvent)
        {
            DefaultMessage = EditorGUILayout.IntField(myGameEvent.Default);
        }
    }
}