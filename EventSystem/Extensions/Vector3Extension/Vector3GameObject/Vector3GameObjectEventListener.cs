using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Vector3Extension.Internal;
using GameEvents.Listeners;

namespace GameEvents.Vector3Extension.Listeners
{
    public class Vector3GameObjectEventListener : TwoArgEventListener<Vector3, GameObject>
    {
        new public Vector3GameObjectGameEvent Event;
        new public Vector3GameObjectEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}