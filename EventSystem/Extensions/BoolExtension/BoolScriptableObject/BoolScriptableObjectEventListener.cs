using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.BoolExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.BoolExtension.Listeners
{
    public class BoolScriptableObjectEventListener : TwoArgEventListener<bool, ScriptableObject>
    {
        new public BoolScriptableObjectGameEvent Event;
        new public BoolScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}