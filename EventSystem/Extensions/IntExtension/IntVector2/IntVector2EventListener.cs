using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.IntExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.IntExtension.Listeners
{
    public class IntVector2EventListener : TwoArgEventListener<int, Vector2>
    {
        new public IntVector2GameEvent Event;
        new public IntVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}