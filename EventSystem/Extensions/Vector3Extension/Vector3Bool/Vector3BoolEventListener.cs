using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector3Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector3Extension.Listeners
{
    public class Vector3BoolEventListener : TwoArgEventListener<Vector3, bool>
    {
        new public Vector3BoolGameEvent Event;
        new public Vector3BoolEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}