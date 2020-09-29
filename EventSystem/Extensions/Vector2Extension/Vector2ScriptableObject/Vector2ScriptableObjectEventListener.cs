using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector2Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector2Extension.Listeners
{
    public class Vector2ScriptableObjectEventListener : TwoArgEventListener<Vector2, ScriptableObject>
    {
        new public Vector2ScriptableObjectGameEvent Event;
        new public Vector2ScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}