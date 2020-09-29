using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using GameEvents.Internal;
using UnityEngine;

namespace GameEvents.GameObjectExtension.Internal
{
    [System.Serializable]
    public class GameObjectStringEvent : TwoArgEvent<GameObject, string>
    {

    }
}