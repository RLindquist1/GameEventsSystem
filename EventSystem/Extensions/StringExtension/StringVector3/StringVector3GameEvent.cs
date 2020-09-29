using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.StringExtension
{
    [CreateAssetMenu(fileName = "StringVector3GameEvent", menuName = "GameEvents/Extensions/StringExtension/StringVector3GameEvent", order = -510)]
    public class StringVector3GameEvent : TwoArgGameEvent<string, Vector3>
    {

    }
}