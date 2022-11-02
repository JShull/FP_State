using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.FSM
{
    public abstract class SO_Decision : ScriptableObject
    {
        public abstract bool Decide(FP_BaseStateMachine state);
    }
}

