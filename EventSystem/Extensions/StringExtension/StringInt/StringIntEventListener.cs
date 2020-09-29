using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.StringExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.StringExtension.Listeners
{
    public class StringIntEventListener : TwoArgEventListener<string, int>
    {
        new public StringIntGameEvent Event;
        new public StringIntEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}