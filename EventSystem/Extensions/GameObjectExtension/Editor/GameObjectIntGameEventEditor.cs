using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.GameObjectExtension.Editors
{
    [CustomEditor(typeof(GameObjectIntGameEvent))]
    public class GameObjectIntGameEventEditor : TwoArgGameEventEditor<GameObject, int>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, int> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, int> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.IntField(myGameEvent.DefaultU);
        }
    }
}