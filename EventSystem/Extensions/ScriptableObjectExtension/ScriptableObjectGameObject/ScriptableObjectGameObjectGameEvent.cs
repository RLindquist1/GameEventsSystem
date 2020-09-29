using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectGameObjectGameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectGameObjectGameEvent", order = -008)]
    public class ScriptableObjectGameObjectGameEvent : TwoArgGameEvent<ScriptableObject, GameObject>
    {

    }
}