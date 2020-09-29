using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.GameObjectExtension.Editors
{
    [CustomEditor(typeof(GameObjectBoolGameEvent))]
    public class GameObjectBoolGameEventEditor : TwoArgGameEventEditor<GameObject, bool>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, bool> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, bool> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Toggle(myGameEvent.DefaultU);
        }
    }
}