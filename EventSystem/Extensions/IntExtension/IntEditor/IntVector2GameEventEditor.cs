using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.IntExtension.Editors
{
    [CustomEditor(typeof(IntVector2GameEvent))]
    public class IntVector2GameEventEditor : TwoArgGameEventEditor<int, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<int, Vector2> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.IntField(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<int, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}