using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class TwoArgEventListener<T, U> : MonoBehaviour
    {
        public TwoArgGameEvent<T, U> Event;
        public TwoArgEvent<T, U> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.DeRegisterListener(this);
        }

        public void OnEventRaised(T a, U b)
        {
            Response.Invoke(a, b);
        }
    }
}