using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.GameObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.GameObjectExtension.Listeners
{
    public class GameObjectScriptableObjectEventListener : TwoArgEventListener<GameObject, ScriptableObject>
    {
        new public GameObjectScriptableObjectGameEvent Event;
        new public GameObjectScriptableObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}