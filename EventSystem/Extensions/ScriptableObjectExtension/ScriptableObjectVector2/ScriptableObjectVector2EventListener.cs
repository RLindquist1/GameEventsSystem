using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.ScriptableObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.ScriptableObjectExtension.Listeners
{
    public class ScriptableObjectVector2EventListener : TwoArgEventListener<ScriptableObject, Vector2>
    {
        new public ScriptableObjectVector2GameEvent Event;
        new public ScriptableObjectVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}