using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector3Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector3Extension.Listeners
{
    public class Vector3ScriptableObjectEventListener : TwoArgEventListener<Vector3, ScriptableObject>
    {
        new public Vector3ScriptableObjectGameEvent Event;
        new public Vector3ScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}