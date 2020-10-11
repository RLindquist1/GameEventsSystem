using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.FloatExtension
{
    [CreateAssetMenu(fileName = "FloatVector3GameEvent", menuName = "GameEvents/Extensions/FloatExtension/FloatVector3GameEvent", order = -660)]
    public class FloatVector3GameEvent : TwoArgGameEvent<float, Vector3>
    {

    }
}