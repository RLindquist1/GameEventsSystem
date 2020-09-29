using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.IntExtension.Editors
{
    [CustomEditor(typeof(IntStringGameEvent))]
    public class IntStringGameEventEditor : TwoArgGameEventEditor<int, string>
    {
        protected override void FirstField(TwoArgGameEvent<int, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<int, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}