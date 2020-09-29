using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoVector3EventListener : TwoArgEventListener<Vector3, Vector3>
    {
        new public TwoVector3GameEvent Event;
        new public TwoVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}