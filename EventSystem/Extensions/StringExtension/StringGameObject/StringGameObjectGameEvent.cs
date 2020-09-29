﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.StringExtension
{
    [CreateAssetMenu(fileName = "StringGameObjectGameEvent", menuName = "GameEvents/Extensions/StringExtension/StringGameObjectGameEvent", order = -509)]
    public class StringGameObjectGameEvent : TwoArgGameEvent<string, GameObject>
    {

    }
}