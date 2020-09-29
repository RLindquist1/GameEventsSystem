using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.GameObjectExtension.Editors
{
    [CustomEditor(typeof(GameObjectFloatGameEvent))]
    public class GameObjectFloatGameEventEditor : TwoArgGameEventEditor<GameObject, float>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, float> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}