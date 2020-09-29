using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.FloatExtension.Editors
{
    [CustomEditor(typeof(FloatStringGameEvent))]
    public class FloatStringGameEventEditor : TwoArgGameEventEditor<float, string>
    {
        protected override void FirstField(TwoArgGameEvent<float, string> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<float, string> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.TextField(myGameEvent.DefaultU);
        }
    }
}