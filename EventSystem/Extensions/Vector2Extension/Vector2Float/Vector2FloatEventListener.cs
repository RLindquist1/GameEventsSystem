using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector2Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector2Extension.Listeners
{
    public class Vector2FloatEventListener : TwoArgEventListener<Vector2, float>
    {
        new public Vector2FloatGameEvent Event;
        new public Vector2FloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}