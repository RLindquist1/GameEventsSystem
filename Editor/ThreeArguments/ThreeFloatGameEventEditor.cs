using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeFloatGameEvent))]
    public class ThreeFloatGameEventEditor : ThreeArgGameEventEditor<float, float, float>
    {
        protected override void FirstField(ThreeArgGameEvent<float, float, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(ThreeArgGameEvent<float, float, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }

        protected override void ThirdField(ThreeArgGameEvent<float, float, float> myGameEvent)
        {
            DefaultMessageV = EditorGUILayout.FloatField(myGameEvent.DefaultV);
        }
    }
}