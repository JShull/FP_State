namespace FuzzPhyte.FSM
{
    using FuzzPhyte.Utility;
    using System;
    [Serializable]
    public abstract class FSM_BaseState : FP_Data
    {
        public abstract void Execute(FP_BaseStateMachine machine);
    }
}

