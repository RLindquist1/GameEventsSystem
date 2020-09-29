using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.BoolExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.BoolExtension.Listeners
{
    public class BoolVector3EventListener : TwoArgEventListener<bool, Vector3>
    {
        new public BoolVector3GameEvent Event;
        new public BoolVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}