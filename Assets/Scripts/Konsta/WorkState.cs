using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Common.SM;

namespace Game.Konsta
{
    public class WorkState : BaseState
    {
        private KonstaStateMachine _sm;
        public WorkState(KonstaStateMachine stateMachine) : base("Work", stateMachine)
        {
            _sm = stateMachine;
        }
    }
}