using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FuzzPhyte.FSM
{
    public class SO_BaseState : ScriptableObject
    {
        public virtual void Execute(FP_BaseStateMachine machine) { }
    }
}

