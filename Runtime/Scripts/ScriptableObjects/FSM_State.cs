namespace FuzzPhyte.FSM
{
    using System.Collections.Generic;
    using UnityEngine;
    using System;
    [Serializable]
    [CreateAssetMenu(fileName = "BaseState", menuName = "FuzzPhyte/FSM/BaseState", order = 0)]

    public class FSM_State : FSM_BaseState
    {
        public List<FSM_BaseAction> Actions = new List<FSM_BaseAction>();
        public List<FSM_Transition> Transitions = new List<FSM_Transition>();

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
