using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.IntExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.IntExtension.Listeners
{
    public class IntVector3EventListener : TwoArgEventListener<int, Vector3>
    {
        new public IntVector3GameEvent Event;
        new public IntVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}