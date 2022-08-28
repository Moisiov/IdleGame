using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Common.SM
{
    public abstract class BaseState
    {
        public string name;
        protected StateMachine stateMachine;

        public BaseState(string name, StateMachine stateMachine)
        {
            this.name = name;
            this.stateMachine = stateMachine;
        }

        public abstract void Enter();
        public abstract void UpdateLogic();
        public abstract void Exit();
    }
}