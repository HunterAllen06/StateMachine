using System;
using System.Collections.Generic;
using UnityEngine;

namespace HunterAllen.StateMachine
{
    /// <summary>
    /// Controls and manages the flow and transitions of two or more states.
    /// </summary>
    public class StateMachine<T> : MonoBehaviour, IStateMachine<T>
    {
        public StateMachineBase<T> StateMachineBase { get; set; }

        #region Initialization
        void Awake()
        {
            StateMachineBase = new StateMachineBase<T>();

            OnInitialize();
        }
        /// <summary>
        /// This is where all states should be initialized.
        /// </summary>
        protected virtual void OnInitialize() { }
        #endregion

        #region Properties and Functions
        /// <summary>
        /// Check to see if a transition to a next state is available and update the current state.
        /// </summary>
        protected virtual void Update() => StateMachineBase.Update();
        protected virtual void FixedUpdate() => StateMachineBase.FixedUpdate();

        public virtual void AddGlobalTransition(IState to, ICondition condition, Action onTransition = null) => StateMachineBase.AddGlobalTransition(to, condition, onTransition);

        /// <summary>
        /// Checks all available transitions and returns one if its condition is met.
        /// </summary>
        /// <returns>The first transition that has a condition that returns true.</returns>
        protected virtual ITransition GetTransition() => StateMachineBase.GetTransition();

        /// <summary>
        /// Exits the current state if one is active, and enters the next state.
        /// </summary>
        /// <param name="transition"></param>
        public void TransitionToState(ITransition transition) => StateMachineBase.TransitionToState(transition);

        public void EnterParallelState(BaseState<T> state) => StateMachineBase.EnterParallelState(state);
        public void ExitParallelState(BaseState<T> state) => StateMachineBase.ExitParallelState(state);
        #endregion
    }
}