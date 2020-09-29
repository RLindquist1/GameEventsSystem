using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.BoolExtension.Editors
{
    [CustomEditor(typeof(BoolStringGameEvent))]
    public class BoolStringGameEventEditor : TwoArgGameEventEditor<bool, string>
    {
        protected override void FirstField(TwoArgGameEvent<bool, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Toggle(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<bool, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}