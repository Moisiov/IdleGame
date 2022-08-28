using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Common.SM
{
    /// <summary>
    /// Generic state machine class. Derive use case specific state machines from this class.
    /// </summary>
    public class StateMachine : MonoBehaviour
    {
        BaseState currentState;

        void Start()
        {
            currentState = GetInitialState();
            if (currentState != null)
                currentState.Enter();
        }

        void Update()
        {
            if (currentState != null)
                currentState.UpdateLogic();
        }

        /// <summary>
        /// Handles state transitions. Triggers current state Exit(),
        /// sets current state to given state object and calls current state Enter().
        /// </summary>
        /// <param name="newState">State to transition in</param>
        public void ChangeState(BaseState newState)
        {
            currentState.Exit();

            currentState = newState;
            currentState.Enter();
        }

        protected virtual BaseState GetInitialState()
        {
            return null;
        }

        public BaseState GetCurrentState()
        {
            return currentState;
        }
    }
}