using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.GameObjectExtension.Editors
{
    [CustomEditor(typeof(GameObjectVector3GameEvent))]
    public class GameObjectVector3GameEventEditor : TwoArgGameEventEditor<GameObject, Vector3>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, Vector3> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, Vector3> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.Vector3Field("", myGameEvent.DefaultU);
        }
    }
}