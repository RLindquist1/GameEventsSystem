using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(TwoGameObjectGameEvent))]
    public class TwoGameObjectGameEventEditor : TwoArgGameEventEditor<GameObject, GameObject>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, GameObject> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, GameObject> myGameEvent)
        {
            DefaultMessageU = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(GameObject), false);
        }
    }
}