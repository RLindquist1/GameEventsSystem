using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using GameEvents.Editors;

namespace GameEvents.BoolExtension.Editors
{
    [CustomEditor(typeof(BoolFloatGameEvent))]
    public class BoolFloatGameEventEditor : TwoArgGameEventEditor<bool, float>
    {
        protected override void FirstField(TwoArgGameEvent<bool, float> myGameEvent)
        {
            DefaultMessageT = EditorGUILayout.Toggle(myGameEvent.DefaultT);
        }

        protected override void SecondField(TwoArgGameEvent<bool, float> myGameEvent)
        {
            DefaultMessageU = EditorGUILayout.FloatField(myGameEvent.DefaultU);
        }
    }
}