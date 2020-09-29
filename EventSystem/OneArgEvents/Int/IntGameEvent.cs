using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents
{
    [CreateAssetMenu(fileName = "IntGameEvent", menuName = "GameEvents/OneArgument/IntGameEvent", order = -920)]
    public class IntGameEvent : OneArgGameEvent<int>
    {
    }
}