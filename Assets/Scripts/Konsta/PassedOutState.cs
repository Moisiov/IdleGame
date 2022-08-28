using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Common.SM;

namespace Game.Konsta
{
    public class PassedOutState : BaseState
    {
        private KonstaStateMachine _sm;
        public PassedOutState(KonstaStateMachine stateMachine) : base("PassedOut", stateMachine)
        {
            _sm = stateMachine;
        }

        public override void UpdateLogic()
        {
            if (ResourceManager.Instance.GetIntoxication() <= 0)
            {
                stateMachine.ChangeState(_sm.idle);
            }
        }
    }
}