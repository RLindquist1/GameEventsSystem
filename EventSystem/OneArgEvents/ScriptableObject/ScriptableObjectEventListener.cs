using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ScriptableObjectEventListener : OneArgEventListener<ScriptableObject>
    {
        new public ScriptableObjectGameEvent Event;
        new public ScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}