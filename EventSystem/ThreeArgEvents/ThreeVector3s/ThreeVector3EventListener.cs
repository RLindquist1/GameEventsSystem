using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeVector3EventListener : ThreeArgEventListener<Vector3, Vector3, Vector3>
    {
        new public ThreeVector3GameEvent Event;
        new public ThreeVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}