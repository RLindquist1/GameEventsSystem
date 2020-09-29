using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace GameEvents.Editors
{
    [CustomEditor(typeof(GameObjectGameEvent))]
    public class GameObjectGameEventEditor : OneArgGameEventEditor<GameObject>
    {
        protected override void FirstArgument(OneArgGameEvent<GameObject> myGameEvent)
        {
            DefaultMessage = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.Default, typeof(GameObject), false);
        }
    }
}