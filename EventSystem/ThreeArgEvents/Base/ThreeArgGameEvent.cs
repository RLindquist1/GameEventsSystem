using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents.Listeners;

namespace GameEvents
{
    public class ThreeArgGameEvent<T, U, V> : ScriptableObject
    {
        private List<ThreeArgEventListener<T, U, V>> listeners = new List<ThreeArgEventListener<T, U, V>>();

        public virtual T DefaultT { get; set; }
        public virtual U DefaultU { get; set; }
        public virtual V DefaultV { get; set; }

        public void Raise()
        {
            Debug.Log("Event " + this.name + " raised with defaults: " + DefaultT + " , " + DefaultU + " , " + DefaultV);
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(DefaultT, DefaultU, DefaultV);
            }
        }

        public void Raise(T a, U b, V c)
        {
            Debug.Log("Event " + this.name + " raised with arguments: " + a + " ," + b + " , " + c);
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(a, b, c);
            }
        }

        public void RegisterListener(ThreeArgEventListener<T, U, V> listener)
        {
            listeners.Add(listener);
        }

        public void DeRegisterListener(ThreeArgEventListener<T, U, V> listener)
        {
            listeners.Remove(listener);
        }
    }
}