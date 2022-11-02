using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.FSM
{
    [Serializable]
    [CreateAssetMenu(fileName = "Transition", menuName = "ScriptableObjects/FuzzPhyte/State/Transition", order = 2)]
    public sealed class SO_Transition : ScriptableObject
    {
        public SO_Decision Decision;
        public SO_BaseState TrueState;
        public SO_BaseState FalseState;

        public void Execute(FP_BaseStateMachine stateMachine) {
            if(Decision.Decide(stateMachine)&&!(TrueState is SO_RemainInState))
            {
                stateMachine.CurrentState = TrueState;
            }else if(!(FalseState is SO_RemainInState))
            {
                stateMachine.CurrentState = FalseState;
            }
        }
    }

}
