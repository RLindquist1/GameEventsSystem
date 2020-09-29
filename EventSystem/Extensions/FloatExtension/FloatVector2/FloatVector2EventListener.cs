using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.FloatExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.FloatExtension.Listeners
{
    public class FloatVector2EventListener : TwoArgEventListener<float, Vector2>
    {
        new public FloatVector2GameEvent Event;
        new public FloatVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}