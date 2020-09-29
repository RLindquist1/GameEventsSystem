using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectBoolGameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectBoolGameEvent", order = -117)]
    public class GameObjectBoolGameEvent : TwoArgGameEvent<GameObject, bool>
    {

    }
}