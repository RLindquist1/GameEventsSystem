using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeBoolGameEvent))]
    public class ThreeBoolGameEventEditor : ThreeArgGameEventEditor<bool, bool, bool>
    {
        protected override void FirstField(ThreeArgGameEvent<bool, bool, bool> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Toggle(myGameEvent.DefaultT);
        }

        protected override void SecondField(ThreeArgGameEvent<bool, bool, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }

        protected override void ThirdField(ThreeArgGameEvent<bool, bool, bool> myGameEvent)
        {
            DefaultMessageV = EditorGUILayout.Toggle(myGameEvent.DefaultV);
        }
    }
}