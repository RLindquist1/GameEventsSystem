using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeBoolEventListener : ThreeArgEventListener<bool, bool, bool>
    {
        new public ThreeBoolGameEvent Event;
        new public ThreeBoolEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}