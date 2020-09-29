using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3GameObjectGameEvent))]
    public class Vector3GameObjectGameEventEditor : TwoArgGameEventEditor<Vector3, GameObject>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, GameObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, GameObject> myGameEvent)
        {
            DefaultMessageU = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(GameObject), false);
        }
    }
}