using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.GameObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.GameObjectExtension.Listeners
{
    public class GameObjectIntEventListener : TwoArgEventListener<GameObject, int>
    {
        new public GameObjectIntGameEvent Event;
        new public GameObjectIntEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}