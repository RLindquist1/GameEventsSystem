using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(ThreeGameObjectGameEvent))]
    public class ThreeGameObjectGameEventEditor : ThreeArgGameEventEditor<GameObject, GameObject, GameObject>
    {
        protected override void FirstField(ThreeArgGameEvent<GameObject, GameObject, GameObject> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(ThreeArgGameEvent<GameObject, GameObject, GameObject> myGameEvent)
        {
            DefaultMessageU = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(GameObject), false);
        }

        protected override void ThirdField(ThreeArgGameEvent<GameObject, GameObject, GameObject> myGameEvent)
        {
            DefaultMessageV = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultV, typeof(GameObject), false);
        }
    }
}