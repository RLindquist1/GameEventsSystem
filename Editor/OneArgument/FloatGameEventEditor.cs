using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(FloatGameEvent))]
    public class FloatGameEventEditor : OneArgGameEventEditor<float>
    {
        protected override void FirstArgument(OneArgGameEvent<float> myGameEvent)
        {
            DefaultMessage = EditorGUILayout.FloatField(myGameEvent.Default);
        }
    }
}