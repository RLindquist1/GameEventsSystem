using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.GameObjectExtension.Editors
{
    [CustomEditor(typeof(GameObjectScriptableObjectGameEvent))]
    public class GameObjectScriptableObjectGameEventEditor : TwoArgGameEventEditor<GameObject, ScriptableObject>
    {
        protected override void FirstField(TwoArgGameEvent<GameObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageT = (GameObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultT, typeof(GameObject), false);
        }

        protected override void SecondField(TwoArgGameEvent<GameObject, ScriptableObject> myGameEvent)
        {
            DefaultMessageU = (ScriptableObject)EditorGUILayout.ObjectField("", myGameEvent.DefaultU, typeof(ScriptableObject), false);
        }
    }
}