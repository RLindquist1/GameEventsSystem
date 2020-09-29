using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.IntExtension
{
    [CreateAssetMenu(fileName = "IntGameObjectGameEvent", menuName = "GameEvents/Extensions/IntExtension/IntGameObjectGameEvent", order = -709)]
    public class IntGameObjectGameEvent : TwoArgGameEvent<int, GameObject>
    {

    }
}