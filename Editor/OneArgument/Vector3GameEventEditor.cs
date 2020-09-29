using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(Vector3GameEvent))]
    public class Vector3GameEventEditor : OneArgGameEventEditor<Vector3>
    {
        protected override void FirstArgument(OneArgGameEvent<Vector3> myGameEvent)
        {
            DefaultMessage = EditorGUILayout.Vector3Field("", myGameEvent.Default);
        }
    }
}