using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using GameEvents.BoolExtension.Internal;
using GameEvents.Listeners;

namespace GameEvents.BoolExtension.Listeners
{
    public class BoolFloatEventListener : TwoArgEventListener<bool, float>
    {
        new public BoolFloatGameEvent Event;
        new public BoolFloatEvent Response;

        void Awake()
        {
            base.Event = this.Event;
            base.Response = this.Response;
        }
    }
}