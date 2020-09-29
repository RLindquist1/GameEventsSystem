using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector2Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector2Extension.Listeners
{
    public class Vector2Vector3EventListener : TwoArgEventListener<Vector2, Vector3>
    {
        new public Vector2Vector3GameEvent Event;
        new public Vector2Vector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}