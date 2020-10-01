using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeIntEventListener : ThreeArgEventListener<int, int, int>
    {
        new public ThreeIntGameEvent Event;
        new public ThreeIntEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}