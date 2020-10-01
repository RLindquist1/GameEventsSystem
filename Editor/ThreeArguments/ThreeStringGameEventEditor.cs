using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeStringGameEvent))]
    public class ThreeStringGameEventEditor : ThreeArgGameEventEditor<string, string, string>
    {
        protected override void FirstField(ThreeArgGameEvent<string, string, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(ThreeArgGameEvent<string, string, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }

        protected override void ThirdField(ThreeArgGameEvent<string, string, string> myGameEvent)
        {
            DefaultMessageV = EditorGUILayout.TextField(myGameEvent.DefaultV);
        }
    }
}