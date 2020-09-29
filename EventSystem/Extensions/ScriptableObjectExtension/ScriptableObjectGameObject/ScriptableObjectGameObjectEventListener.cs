using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.ScriptableObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.ScriptableObjectExtension.Listeners
{
    public class ScriptableObjectGameObjectEventListener : TwoArgEventListener<ScriptableObject, GameObject>
    {
        new public ScriptableObjectGameObjectGameEvent Event;
        new public ScriptableObjectGameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}