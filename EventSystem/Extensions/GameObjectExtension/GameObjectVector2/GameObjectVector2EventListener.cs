using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.GameObjectExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.GameObjectExtension.Listeners
{
    public class GameObjectVector2EventListener : TwoArgEventListener<GameObject, Vector2>
    {
        new public GameObjectVector2GameEvent Event;
        new public GameObjectVector2Event Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}