using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Common.SM;

namespace Game.Konsta
{
    public class KonstaStateMachine : StateMachine
    {
        [HideInInspector]
        public IdleState idle;
        [HideInInspector]
        public AdventureState adventure;
        [HideInInspector]
        public WorkState work;
        [HideInInspector]
        public PassedOutState passedOut;

        void Awake()
        {
            idle = new IdleState(this);
            adventure = new AdventureState(this);
            work = new WorkState(this);
            passedOut = new PassedOutState(this);
        }

        protected override BaseState GetInitialState()
        {
            return idle;
        }
    }

}