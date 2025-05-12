namespace FuzzPhyte.FSM
{
    using FuzzPhyte.Utility;
    using System;
    [Serializable]
    public abstract class FSM_BaseAction : FP_Data
    {
        public abstract void Execute(FP_BaseStateMachine stateMachine);
    }
}

