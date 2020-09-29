using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.FloatExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.FloatExtension.Listeners
{
    public class FloatVector3EventListener : TwoArgEventListener<float, Vector3>
    {
        new public FloatVector3GameEvent Event;
        new public FloatVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}