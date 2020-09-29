using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.ScriptableObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.ScriptableObjectExtension.Listeners
{
    public class ScriptableObjectBoolEventListener : TwoArgEventListener<ScriptableObject, bool>
    {
        new public ScriptableObjectBoolGameEvent Event;
        new public ScriptableObjectBoolEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}