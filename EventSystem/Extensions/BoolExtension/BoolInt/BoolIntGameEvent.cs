using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.BoolExtension
{
    [CreateAssetMenu(fileName = "BoolIntGameEvent", menuName = "GameEvents/Extensions/BoolExtension/BoolIntGameEvent", order = -570)]
    public class BoolIntGameEvent : TwoArgGameEvent<bool, int>
    {

    }
}