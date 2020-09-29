using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.FloatExtension.Editors
{
    [CustomEditor(typeof(FloatIntGameEvent))]
    public class FloatIntGameEventEditor : TwoArgGameEventEditor<float, int>
    {
        protected override void FirstField(TwoArgGameEvent<float, int> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<float, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}