using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.FloatExtension.Editors
{
    [CustomEditor(typeof(FloatVector2GameEvent))]
    public class FloatVector2GameEventEditor : TwoArgGameEventEditor<float, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<float, Vector2> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.FloatField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<float, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}