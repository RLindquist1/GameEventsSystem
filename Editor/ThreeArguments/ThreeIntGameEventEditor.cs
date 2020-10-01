using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeIntGameEvent))]
    public class ThreeIntGameEventEditor : ThreeArgGameEventEditor<int, int, int>
    {
        protected override void FirstField(ThreeArgGameEvent<int, int, int> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(ThreeArgGameEvent<int, int, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }

        protected override void ThirdField(ThreeArgGameEvent<int, int, int> myGameEvent)
        {
            DefaultMessageV = EditorGUILayout.IntField(myGameEvent.DefaultV);
        }
    }
}