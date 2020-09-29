using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.ScriptableObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.ScriptableObjectExtension.Listeners
{
    public class ScriptableObjectIntEventListener : TwoArgEventListener<ScriptableObject, int>
    {
        new public ScriptableObjectIntGameEvent Event;
        new public ScriptableObjectIntEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}