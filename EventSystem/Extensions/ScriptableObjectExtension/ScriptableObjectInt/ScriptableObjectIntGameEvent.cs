﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectIntGameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectIntGameEvent", order = -020)]
    public class ScriptableObjectIntGameEvent : TwoArgGameEvent<ScriptableObject, int>
    {

    }
}