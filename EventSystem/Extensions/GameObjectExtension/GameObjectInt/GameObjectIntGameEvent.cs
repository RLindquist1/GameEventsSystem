using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectIntGameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectIntGameEvent", order = -120)]
    public class GameObjectIntGameEvent : TwoArgGameEvent<GameObject, int>
    {

    }
}