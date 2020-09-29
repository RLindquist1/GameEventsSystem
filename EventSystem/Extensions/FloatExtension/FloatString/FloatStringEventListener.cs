using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.FloatExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.FloatExtension.Listeners
{
    public class FloatStringEventListener : TwoArgEventListener<float, string>
    {
        new public FloatStringGameEvent Event;
        new public FloatStringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}