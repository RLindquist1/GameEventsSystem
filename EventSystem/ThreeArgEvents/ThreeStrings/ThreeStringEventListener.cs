using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeStringEventListener : ThreeArgEventListener<string, string, string>
    {
        new public ThreeStringGameEvent Event;
        new public ThreeStringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}