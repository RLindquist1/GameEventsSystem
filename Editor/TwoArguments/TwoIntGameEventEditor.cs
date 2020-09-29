using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(TwoIntGameEvent))]
    public class TwoIntGameEventEditor : TwoArgGameEventEditor<int, int>
    {
        protected override void FirstField(TwoArgGameEvent<int, int> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<int, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}