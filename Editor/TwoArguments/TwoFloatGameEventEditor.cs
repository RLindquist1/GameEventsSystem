using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(TwoFloatGameEvent))]
    public class TwoFloatGameEventEditor : TwoArgGameEventEditor<float, float>
    {
        protected override void FirstField(TwoArgGameEvent<float, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<float, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}