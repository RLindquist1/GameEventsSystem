﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectFloatGameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectFloatGameEvent", order = -269)]
    public class ScriptableObjectFloatGameEvent : TwoArgGameEvent<ScriptableObject, float>
    {

    }
}