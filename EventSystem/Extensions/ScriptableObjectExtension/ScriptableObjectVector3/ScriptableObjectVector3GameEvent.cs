using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectVector3GameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectVector3GameEvent", order = -009)]
    public class ScriptableObjectVector3GameEvent : TwoArgGameEvent<ScriptableObject, Vector3>
    {

    }
}