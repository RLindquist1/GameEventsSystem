using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectStringGameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectStringGameEvent", order = -118)]
    public class GameObjectStringGameEvent : TwoArgGameEvent<GameObject, string>
    {

    }
}