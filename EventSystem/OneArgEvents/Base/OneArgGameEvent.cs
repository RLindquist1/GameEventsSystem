using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents.Listeners;

namespace GameEvents
{

    public class OneArgGameEvent<T> : ScriptableObject
    {
        private List<OneArgEventListener<T>> listeners = new List<OneArgEventListener<T>>();
        public virtual T Default { get; set; }

        public void Raise()
        {
            Debug.Log("Event " + this.name + " raised with default: " + Default);
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(Default);
            }
        }

        public void Raise(T a)
        {
            Debug.Log("Event " + this.name + " raised with argument: " + a);
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(a);
            }
        }

        public void RegisterListener(OneArgEventListener<T> listener)
        {
            listeners.Add(listener);
        }

        public void DeRegisterListener(OneArgEventListener<T> listener)
        {
            listeners.Remove(listener);
        }
    }
}
