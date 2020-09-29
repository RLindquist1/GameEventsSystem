using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class OneArgEventListener<T> : MonoBehaviour
    {
        public OneArgGameEvent<T> Event;
        public OneArgEvent<T> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.DeRegisterListener(this);
        }

        public void OnEventRaised(T a)
        {
            Response.Invoke(a);
        }
    }
}
