using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoFloatEventListener : TwoArgEventListener<float, float>
    {
        new public TwoFloatGameEvent Event;
        new public TwoFloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}