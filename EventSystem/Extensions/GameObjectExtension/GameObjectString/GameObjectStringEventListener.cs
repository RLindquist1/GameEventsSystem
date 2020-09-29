using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.GameObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.GameObjectExtension.Listeners
{
    public class GameObjectStringEventListener : TwoArgEventListener<GameObject, string>
    {
        new public GameObjectStringGameEvent Event;
        new public GameObjectStringEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}