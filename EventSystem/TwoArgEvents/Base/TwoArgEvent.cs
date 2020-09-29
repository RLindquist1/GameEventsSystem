using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

namespace GameEvents.Internal
{
    [System.Serializable]
    public class TwoArgEvent<T, U> : UnityEvent<T, U>
    {

    }
}