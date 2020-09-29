using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.StringExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.StringExtension.Listeners
{
    public class StringVector3EventListener : TwoArgEventListener<string, Vector3>
    {
        new public StringVector3GameEvent Event;
        new public StringVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}