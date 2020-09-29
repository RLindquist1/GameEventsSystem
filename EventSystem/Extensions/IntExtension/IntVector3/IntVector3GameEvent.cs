using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.IntExtension
{
    [CreateAssetMenu(fileName = "IntVector3GameEvent", menuName = "GameEvents/Extensions/IntExtension/IntVector3GameEvent", order = -710)]
    public class IntVector3GameEvent : TwoArgGameEvent<int, Vector3>
    {

    }
}