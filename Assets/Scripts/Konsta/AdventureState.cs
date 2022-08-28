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
            if (ResourceManager.Instance.GetAlcohol() <= 0)
            {
                stateMachine.ChangeState(_sm.idle);
            }

            if (ResourceManager.Instance.GetIntoxication() >= 5.0)
            {
                stateMachine.ChangeState(_sm.passedOut);
            }
        }
        public override void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}