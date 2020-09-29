using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEventExamples
{
    public class GameStartReceiver : MonoBehaviour
    {
        public void Start()
        {
            Time.timeScale = 0;
        }

        // Function called by the EventSystem must be public and return void.
        public void ReceiveGameStart()
        {
            Time.timeScale = 1;
        }
    }
}