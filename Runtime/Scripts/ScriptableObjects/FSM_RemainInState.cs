namespace FuzzPhyte.FSM
{
    using System;
    using UnityEngine;

    [Serializable]
    [CreateAssetMenu(fileName = "RemainState", menuName = "FuzzPhyte/FSM/RemainState", order = 1)]
    public sealed class FSM_RemainInState : FSM_BaseState
    {
        public override void Execute(FP_BaseStateMachine machine)
        {
            //throw new NotImplementedException();
        }
    }
}
