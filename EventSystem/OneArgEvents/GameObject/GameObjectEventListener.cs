using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class GameObjectEventListener : OneArgEventListener<GameObject>
    {
        new public GameObjectGameEvent Event;
        new public GameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}