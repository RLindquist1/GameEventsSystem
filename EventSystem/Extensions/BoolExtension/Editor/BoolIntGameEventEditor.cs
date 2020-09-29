using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.BoolExtension.Editors
{
    [CustomEditor(typeof(BoolIntGameEvent))]
    public class BoolIntGameEventEditor : TwoArgGameEventEditor<bool, int>
    {
        protected override void FirstField(TwoArgGameEvent<bool, int> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Toggle(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<bool, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}