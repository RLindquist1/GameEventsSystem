using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectIntGameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectIntGameEvent", order = -320)]
    public class GameObjectIntGameEvent : TwoArgGameEvent<GameObject, int>
    {

    }
}