using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents
{
    [CreateAssetMenu(fileName = "ThreeStringGameEvent", menuName = "GameEvents/ThreeArguments/ThreeStringGameEvent", order = -768)]
    public class ThreeStringGameEvent : ThreeArgGameEvent<string, string, string>
    {

    }
}