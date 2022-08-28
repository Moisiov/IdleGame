using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Common.SM;

namespace Game.Konsta
{
    public class PassedOutState : BaseState
    {
        public PassedOutState(StateMachine stateMachine) : base("PassedOut", stateMachine) { }
        public override void Enter()
        {
            throw new System.NotImplementedException();
        }
        public override void UpdateLogic()
        {
            throw new System.NotImplementedException();
        }
        public override void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}