using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.FloatExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.FloatExtension.Listeners
{
    public class FloatIntEventListener : TwoArgEventListener<float, int>
    {
        new public FloatIntGameEvent Event;
        new public FloatIntEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}