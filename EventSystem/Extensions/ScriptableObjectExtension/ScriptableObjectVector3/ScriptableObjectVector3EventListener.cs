using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.ScriptableObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.ScriptableObjectExtension.Listeners
{
    public class ScriptableObjectVector3EventListener : TwoArgEventListener<ScriptableObject, Vector3>
    {
        new public ScriptableObjectVector3GameEvent Event;
        new public ScriptableObjectVector3Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}