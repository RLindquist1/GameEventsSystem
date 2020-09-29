using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.BoolExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.BoolExtension.Listeners
{
    public class BoolVector2EventListener : TwoArgEventListener<bool, Vector2>
    {
        new public BoolVector2GameEvent Event;
        new public BoolVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}