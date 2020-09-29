using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector2Extension.Editors
{
    [CustomEditor(typeof(Vector2ScriptableObjectGameEvent))]
    public class Vector2ScriptableObjectGameEventEditor : TwoArgGameEventEditor<Vector2, ScriptableObject>
    {
        protected override void FirstField(TwoArgGameEvent<Vector2, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector2, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }
    }
}