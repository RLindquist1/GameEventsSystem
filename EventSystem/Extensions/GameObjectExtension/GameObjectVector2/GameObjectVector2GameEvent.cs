using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.GameObjectExtension
{
    [CreateAssetMenu(fileName = "GameObjectVector2GameEvent", menuName = "GameEvents/Extensions/GameObjectExtension/GameObjectVector2GameEvent", order = -110)]
    public class GameObjectVector2GameEvent : TwoArgGameEvent<GameObject, Vector2>
    {

    }
}