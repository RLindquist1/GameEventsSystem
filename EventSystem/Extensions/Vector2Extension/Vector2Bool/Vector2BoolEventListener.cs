using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector2Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector2Extension.Listeners
{
    public class Vector2BoolEventListener : TwoArgEventListener<Vector2, bool>
    {
        new public Vector2BoolGameEvent Event;
        new public Vector2BoolEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}