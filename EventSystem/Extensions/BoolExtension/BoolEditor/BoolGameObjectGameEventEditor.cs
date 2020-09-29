using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.BoolExtension.Editors
{
    [CustomEditor(typeof(BoolGameObjectGameEvent))]
    public class BoolGameObjectGameEventEditor : TwoArgGameEventEditor<bool, GameObject>
    {
        protected override void FirstField(TwoArgGameEvent<bool, GameObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Toggle(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<bool, GameObject> myGameEvent)
        {
            DefaultMessageU = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(GameObject), false);
        }
    }
}