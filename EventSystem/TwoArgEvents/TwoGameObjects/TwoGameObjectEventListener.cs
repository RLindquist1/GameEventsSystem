using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoGameObjectEventListener : TwoArgEventListener<GameObject, GameObject>
    {
        new public TwoGameObjectGameEvent Event;
        new public TwoGameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}