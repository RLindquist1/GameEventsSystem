using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.IntExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.IntExtension.Listeners
{
    public class IntStringEventListener : TwoArgEventListener<int, string>
    {
        new public IntStringGameEvent Event;
        new public IntStringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}