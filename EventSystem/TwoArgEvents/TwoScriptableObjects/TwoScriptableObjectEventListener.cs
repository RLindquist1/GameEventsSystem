using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoScriptableObjectEventListener : TwoArgEventListener<ScriptableObject, ScriptableObject>
    {
        new public TwoScriptableObjectGameEvent Event;
        new public TwoScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}