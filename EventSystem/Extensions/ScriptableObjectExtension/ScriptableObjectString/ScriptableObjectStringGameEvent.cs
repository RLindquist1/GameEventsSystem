using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectStringGameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectStringGameEvent", order = -268)]
    public class ScriptableObjectStringGameEvent : TwoArgGameEvent<ScriptableObject, string>
    {

    }
}