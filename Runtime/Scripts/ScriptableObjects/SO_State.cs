using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.FSM
{
    [Serializable]
    [CreateAssetMenu(fileName = "BaseState", menuName = "ScriptableObjects/FuzzPhyte/State/BaseState", order = 0)]

    public class SO_State : SO_BaseState
    {
        public List<SO_Action> Actions = new List<SO_Action>();
        public List<SO_Transition> Transitions = new List<SO_Transition>();

        public override void Execute(FP_BaseStateMachine machine)
        {
            foreach(var action in Actions)
            {
                action.Execute(machine);
            }
            foreach(var transition in Transitions)
            {
                transition.Execute(machine);
            }
        }
    }

}
