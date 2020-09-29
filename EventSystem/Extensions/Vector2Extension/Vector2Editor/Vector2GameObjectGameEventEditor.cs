using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector2Extension.Editors
{
    [CustomEditor(typeof(Vector2GameObjectGameEvent))]
    public class Vector2GameObjectGameEventEditor : TwoArgGameEventEditor<Vector2, GameObject>
    {
        protected override void FirstField(TwoArgGameEvent<Vector2, GameObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector2Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector2, GameObject> myGameEvent)
        {
            DefaultMessageU = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(GameObject), false);
        }
    }
}