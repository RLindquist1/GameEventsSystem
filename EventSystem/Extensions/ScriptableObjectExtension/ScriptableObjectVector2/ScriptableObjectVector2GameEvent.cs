using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEvents.ScriptableObjectExtension
{
    [CreateAssetMenu(fileName = "ScriptableObjectVector2GameEvent", menuName = "GameEvents/Extensions/ScriptableObjectExtension/ScriptableObjectVector2GameEvent", order = -010)]
    public class ScriptableObjectVector2GameEvent : TwoArgGameEvent<ScriptableObject, Vector2>
    {

    }
}