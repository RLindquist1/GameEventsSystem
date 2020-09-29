using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameEvents.Listeners;

namespace GameEvents
{
    [CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvents/GameEvent", order = -1000)]
    public class GameEvent : ScriptableObject
    {
        private List<GameEventListener> listeners = new List<GameEventListener>();

        public void Raise()
        {
            Debug.Log("Event " + this.name + " raised.");
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventListener listener)
        {
            listeners.Add(listener);
        }

        public void DeRegisterListener(GameEventListener listener)
        {
            listeners.Remove(listener);
        }
    }
}