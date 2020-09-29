using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector3Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector3Extension.Listeners
{
    public class Vector3FloatEventListener : TwoArgEventListener<Vector3, float>
    {
        new public Vector3FloatGameEvent Event;
        new public Vector3FloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}