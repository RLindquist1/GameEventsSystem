using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.BoolExtension
{
    [CreateAssetMenu(fileName = "BoolGameObjectGameEvent", menuName = "GameEvents/Extensions/BoolExtension/BoolGameObjectGameEvent", order = -409)]
    public class BoolGameObjectGameEvent : TwoArgGameEvent<bool, GameObject>
    {

    }
}