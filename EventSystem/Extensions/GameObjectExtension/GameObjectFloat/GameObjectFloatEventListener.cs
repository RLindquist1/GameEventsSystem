using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.GameObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.GameObjectExtension.Listeners
{
    public class GameObjectFloatEventListener : TwoArgEventListener<GameObject, float>
    {
        new public GameObjectFloatGameEvent Event;
        new public GameObjectFloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}