using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.FloatExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.FloatExtension.Listeners
{
    public class FloatBoolEventListener : TwoArgEventListener<float, bool>
    {
        new public FloatBoolGameEvent Event;
        new public FloatBoolEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}