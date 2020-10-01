using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.Internal;

namespace GameEvents.Listeners
{
    public class ThreeArgEventListener<T, U, V> : MonoBehaviour
    {
        public ThreeArgGameEvent<T, U, V> Event;
        public ThreeArgEvent<T, U, V> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.DeRegisterListener(this);
        }

        public void OnEventRaised(T a, U b, V c)
        {
            Response.Invoke(a, b, c);
        }
    }
}