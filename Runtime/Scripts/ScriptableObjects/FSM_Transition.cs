namespace FuzzPhyte.FSM
{
    using FuzzPhyte.Utility;
    using UnityEngine;
    using System;
    [Serializable]
    [CreateAssetMenu(fileName = "Transition", menuName = "FuzzPhyte/FSM/Transition", order = 2)]
    public sealed class FSM_Transition : FP_Data
    {
        public FSM_BaseDecision Decision;
        public FSM_BaseState TrueState;
        public FSM_BaseState FalseState;

        public void Execute(FP_BaseStateMachine stateMachine) {
            if(Decision.Decide(stateMachine)&&!(TrueState is FSM_RemainInState))
            {
                stateMachine.CurrentState = TrueState;
            }else if(!(FalseState is FSM_RemainInState))
            {
                stateMachine.CurrentState = FalseState;
            }
        }
    }

}
