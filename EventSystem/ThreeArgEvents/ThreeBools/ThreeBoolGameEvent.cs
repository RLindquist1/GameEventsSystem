using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents
{
    [CreateAssetMenu(fileName = "ThreeBoolGameEvent", menuName = "GameEvents/ThreeArguments/ThreeBoolGameEvent", order = -767)] // Nice.
    public class ThreeBoolGameEvent : ThreeArgGameEvent<bool, bool, bool>
    {

    }
}