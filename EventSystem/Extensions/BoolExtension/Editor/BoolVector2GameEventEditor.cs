using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.BoolExtension.Editors
{
    [CustomEditor(typeof(BoolVector2GameEvent))]
    public class BoolVector2GameEventEditor : TwoArgGameEventEditor<bool, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<bool, Vector2> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Toggle(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<bool, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}