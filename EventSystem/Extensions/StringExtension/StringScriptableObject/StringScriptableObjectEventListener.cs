using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.StringExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.StringExtension.Listeners
{
    public class StringScriptableObjectEventListener : TwoArgEventListener<string, ScriptableObject>
    {
        new public StringScriptableObjectGameEvent Event;
        new public StringScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}