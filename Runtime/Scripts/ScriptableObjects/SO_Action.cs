using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.FSM
{
    public abstract class SO_Action : ScriptableObject
    {
        public abstract void Execute(FP_BaseStateMachine stateMachine);
    }
}

