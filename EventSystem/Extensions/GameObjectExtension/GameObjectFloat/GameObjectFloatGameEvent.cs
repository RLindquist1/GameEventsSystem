using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectFloatGameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectFloatGameEvent", order = -119)]
    public class GameObjectFloatGameEvent : TwoArgGameEvent<GameObject, float>
    {

    }
}