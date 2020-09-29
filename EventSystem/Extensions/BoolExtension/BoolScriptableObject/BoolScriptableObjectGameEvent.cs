using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.BoolExtension
{
    [CreateAssetMenu(fileName = "BoolScriptableObjectGameEvent", menuName = "GameEvents/Extensions/BoolExtension/BoolScriptableObjectGameEvent", order = -408)]
    public class BoolScriptableObjectGameEvent : TwoArgGameEvent<bool, ScriptableObject>
    {

    }
}