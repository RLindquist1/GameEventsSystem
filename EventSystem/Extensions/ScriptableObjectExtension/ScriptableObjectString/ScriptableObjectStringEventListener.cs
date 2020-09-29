using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.ScriptableObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.ScriptableObjectExtension.Listeners
{
    public class ScriptableObjectStringEventListener : TwoArgEventListener<ScriptableObject, string>
    {
        new public ScriptableObjectStringGameEvent Event;
        new public ScriptableObjectStringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}