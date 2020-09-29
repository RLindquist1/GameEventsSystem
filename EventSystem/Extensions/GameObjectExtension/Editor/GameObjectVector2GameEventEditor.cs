using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.GameObjectExtension.Editors
{
    [CustomEditor(typeof(GameObjectVector2GameEvent))]
    public class GameObjectVector2GameEventEditor : TwoArgGameEventEditor<GameObject, Vector2>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, Vector2> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, Vector2> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector2Field("", myGameEvent.DefaultU);
        }
    }
}