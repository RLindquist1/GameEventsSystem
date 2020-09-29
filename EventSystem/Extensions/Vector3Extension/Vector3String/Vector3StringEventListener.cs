using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector3Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector3Extension.Listeners
{
    public class Vector3StringEventListener : TwoArgEventListener<Vector3, string>
    {
        new public Vector3StringGameEvent Event;
        new public Vector3StringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}