using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoVector2EventListener : TwoArgEventListener<Vector2, Vector2>
    {
        new public TwoVector2GameEvent Event;
        new public TwoVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}