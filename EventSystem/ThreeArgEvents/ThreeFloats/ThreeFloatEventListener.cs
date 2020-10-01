using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeFloatEventListener : ThreeArgEventListener<float, float, float>
    {
        new public ThreeFloatGameEvent Event;
        new public ThreeFloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}