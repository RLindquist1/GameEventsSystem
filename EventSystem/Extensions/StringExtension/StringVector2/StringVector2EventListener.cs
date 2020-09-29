using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.StringExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.StringExtension.Listeners
{
    public class StringVector2EventListener : TwoArgEventListener<string, Vector2>
    {
        new public StringVector2GameEvent Event;
        new public StringVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}