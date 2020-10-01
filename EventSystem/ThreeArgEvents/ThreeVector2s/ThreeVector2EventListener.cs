using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeVector2EventListener : ThreeArgEventListener<Vector2, Vector2, Vector2>
    {
        new public ThreeVector2GameEvent Event;
        new public ThreeVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}