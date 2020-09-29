using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.BoolExtension
{
    [CreateAssetMenu(fileName = "BoolVector3GameEvent", menuName = "GameEvents/Extensions/BoolExtension/BoolVector3GameEvent", order = -410)]
    public class BoolVector3GameEvent : TwoArgGameEvent<bool, Vector3>
    {

    }
}