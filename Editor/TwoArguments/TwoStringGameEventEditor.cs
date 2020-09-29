using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(TwoStringGameEvent))]
    public class TwoStringGameEventEditor : TwoArgGameEventEditor<string, string>
    {
        protected override void FirstField(TwoArgGameEvent<string, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.TextField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<string, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}