using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Common.SM;

namespace Game.Konsta
{
    public class AdventureState : BaseState
    {
        private KonstaStateMachine _sm;
        public AdventureState(KonstaStateMachine stateMachine) : base("Adventure", stateMachine)
        {
            _sm = stateMachine;
        }
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