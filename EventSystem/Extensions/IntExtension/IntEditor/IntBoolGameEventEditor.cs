using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.IntExtension.Editors
{
    [CustomEditor(typeof(IntBoolGameEvent))]
    public class IntBoolGameEventEditor : TwoArgGameEventEditor<int, bool>
    {
        protected override void FirstField(TwoArgGameEvent<int, bool> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<int, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }
    }
}