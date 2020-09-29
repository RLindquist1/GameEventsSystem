using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.IntExtension.Editors
{
    [CustomEditor(typeof(IntFloatGameEvent))]
    public class IntFloatGameEventEditor : TwoArgGameEventEditor<int, float>
    {
        protected override void FirstField(TwoArgGameEvent<int, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<int, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}