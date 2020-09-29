using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectVector3GameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectVector3GameEvent", order = -109)]
    public class GameObjectVector3GameEvent : TwoArgGameEvent<GameObject, Vector3>
    {

    }
}