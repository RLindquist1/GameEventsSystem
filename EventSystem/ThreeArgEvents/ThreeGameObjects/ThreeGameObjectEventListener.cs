using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeGameObjectEventListener : ThreeArgEventListener<GameObject, GameObject, GameObject>
    {
        new public ThreeGameObjectGameEvent Event;
        new public ThreeGameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}