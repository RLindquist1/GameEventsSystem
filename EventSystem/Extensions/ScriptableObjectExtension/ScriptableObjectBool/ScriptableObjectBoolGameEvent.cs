﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectBoolGameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectBoolGameEvent", order = -017)]
    public class ScriptableObjectBoolGameEvent : TwoArgGameEvent<ScriptableObject, bool>
    {

    }
}