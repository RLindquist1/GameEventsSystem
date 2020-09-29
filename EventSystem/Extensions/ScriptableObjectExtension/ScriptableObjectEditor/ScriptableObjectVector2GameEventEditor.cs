using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.ScriptableObjectExtension.Editors
{
    [CustomEditor(typeof(ScriptableObjectVector2GameEvent))]
    public class ScriptableObjectVector2GameEventEditor : TwoArgGameEventEditor<ScriptableObject, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<ScriptableObject, Vector2> myGameEvent)
        {
            DefaultMessageT = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(ScriptableObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<ScriptableObject, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}