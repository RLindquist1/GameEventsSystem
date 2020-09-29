using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.Vector3Extension.Editors
{
    [CustomEditor(typeof(Vector3ScriptableObjectGameEvent))]
    public class Vector3ScriptableObjectGameEventEditor : TwoArgGameEventEditor<Vector3, ScriptableObject>
    {
        protected override void FirstField(TwoArgGameEvent<Vector3, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Vector3Field("", myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<Vector3, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }
    }
}