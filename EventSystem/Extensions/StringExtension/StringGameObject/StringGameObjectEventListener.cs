using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.StringExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.StringExtension.Listeners
{
    public class StringGameObjectEventListener : TwoArgEventListener<string, GameObject>
    {
        new public StringGameObjectGameEvent Event;
        new public StringGameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}