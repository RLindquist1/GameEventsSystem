using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectScriptableObjectGameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectScriptableObjectGameEvent", order = -108)]
    public class GameObjectScriptableObjectGameEvent : TwoArgGameEvent<GameObject, ScriptableObject>
    {

    }
}