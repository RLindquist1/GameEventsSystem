using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.IntExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.IntExtension.Listeners
{
    public class IntFloatEventListener : TwoArgEventListener<int, float>
    {
        new public IntFloatGameEvent Event;
        new public IntFloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}