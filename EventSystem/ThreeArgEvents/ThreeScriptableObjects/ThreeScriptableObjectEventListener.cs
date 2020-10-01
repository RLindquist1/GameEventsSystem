using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeScriptableObjectEventListener : ThreeArgEventListener<ScriptableObject, ScriptableObject, ScriptableObject>
    {
        new public ThreeScriptableObjectGameEvent Event;
        new public ThreeScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}