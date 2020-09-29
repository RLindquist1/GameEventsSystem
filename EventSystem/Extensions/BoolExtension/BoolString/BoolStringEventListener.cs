using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.BoolExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.BoolExtension.Listeners
{
    public class BoolStringEventListener : TwoArgEventListener<bool, string>
    {
        new public BoolStringGameEvent Event;
        new public BoolStringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}