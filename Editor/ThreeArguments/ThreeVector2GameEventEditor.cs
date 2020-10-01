using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeVector2GameEvent))]
    public class ThreeVector2GameEventEditor : ThreeArgGameEventEditor<Vector2, Vector2, Vector2>
    {
        protected override void FirstField(ThreeArgGameEvent<Vector2, Vector2, Vector2> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(ThreeArgGameEvent<Vector2, Vector2, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }

        protected override void ThirdField(ThreeArgGameEvent<Vector2, Vector2, Vector2> myGameEvent)
        {
            DefaultMessageV = EditorGUILayout.Vector2Field("", myGameEvent.DefaultV);
        }
    }
}