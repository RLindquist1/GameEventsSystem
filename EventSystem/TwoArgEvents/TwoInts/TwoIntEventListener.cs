using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoIntEventListener : TwoArgEventListener<int, int>
    {
        new public TwoIntGameEvent Event;
        new public TwoIntEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}