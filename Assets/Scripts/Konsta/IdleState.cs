using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Common.SM;

namespace Game.Konsta
{
    public class IdleState : BaseState
    {
        private KonstaStateMachine _sm;
        public IdleState(KonstaStateMachine stateMachine) : base("Idle", stateMachine)
        {
            _sm = stateMachine;
        }
    }
}