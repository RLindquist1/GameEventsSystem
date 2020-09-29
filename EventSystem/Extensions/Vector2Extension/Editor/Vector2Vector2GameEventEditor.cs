using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector2Extension.Editors
{
    [CustomEditor(typeof(Vector2FloatGameEvent))]
    public class Vector2FloatGameEventEditor : TwoArgGameEventEditor<Vector2, float>
    {
        protected override void FirstField(TwoArgGameEvent<Vector2, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector2, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}