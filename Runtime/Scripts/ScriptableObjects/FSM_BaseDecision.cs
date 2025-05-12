namespace FuzzPhyte.FSM
{
    using FuzzPhyte.Utility;
    using System;
    [Serializable]
    public abstract class FSM_BaseDecision : FP_Data
    {
        public abstract bool Decide(FP_BaseStateMachine state);
    }
}

