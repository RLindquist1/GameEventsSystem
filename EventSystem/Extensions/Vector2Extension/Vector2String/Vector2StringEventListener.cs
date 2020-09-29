using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector2Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector2Extension.Listeners
{
    public class Vector2StringEventListener : TwoArgEventListener<Vector2, string>
    {
        new public Vector2StringGameEvent Event;
        new public Vector2StringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}