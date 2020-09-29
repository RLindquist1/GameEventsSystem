using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Using statement required to use GameEvent system
using GameEvents;

namespace GameEventExamples
{
    public class GameStartSender : MonoBehaviour
    {
        // The GameEvent will be created in the Asset menu, and set in the inspector. This GameEvent should be the same as the one on the target Receiver.
        public GameEvent startGameEvent;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Calling Raise() on a GameEvent will call the OnEventRaised() function on all of that GameEvent's listeners, which will call those listeners' UnityEvents.
                startGameEvent.Raise();
            }
        }
    }
}