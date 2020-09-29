using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents.Listeners;

namespace GameEvents
{
    public class TwoArgGameEvent<T, U> : ScriptableObject
    {
        private List<TwoArgEventListener<T, U>> listeners = new List<TwoArgEventListener<T, U>>();

        public virtual T DefaultT { get; set; }
        public virtual U DefaultU { get; set; }

        public void Raise()
        {
            Debug.Log("Event " + this.name + " raised with defaults: " + DefaultT + " , " + DefaultU);
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(DefaultT, DefaultU);
            }
        }

        public void Raise(T a, U b)
        {
            Debug.Log("Event " + this.name + " raised.");
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(a, b);
            }
        }

        public void RegisterListener(TwoArgEventListener<T, U> listener)
        {
            listeners.Add(listener);
        }

        public void DeRegisterListener(TwoArgEventListener<T, U> listener)
        {
            listeners.Remove(listener);
        }
    }
}