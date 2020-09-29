using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(Vector2GameEvent))]
    public class Vector2GameEventEditor : OneArgGameEventEditor<Vector2>
    {
        protected override void FirstArgument(OneArgGameEvent<Vector2> myGameEvent)
        {
            DefaultMessage = EditorGUILayout.Vector2Field("", myGameEvent.Default);
        }
    }
}