using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.IntExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.IntExtension.Listeners
{
    public class IntGameObjectEventListener : TwoArgEventListener<int, GameObject>
    {
        new public IntGameObjectGameEvent Event;
        new public IntGameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}