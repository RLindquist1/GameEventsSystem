using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.StringExtension
{
    [CreateAssetMenu(fileName = "StringScriptableObjectGameEvent", menuName = "GameEvents/Extensions/StringExtension/StringScriptableObjectGameEvent", order = -608)]
    public class StringScriptableObjectGameEvent : TwoArgGameEvent<string, ScriptableObject>
    {

    }
}