using System;
using System.Collections.Generic;

namespace HunterAllen.StateMachine
{
    /// <summary>
    /// Controls and manages the flow and transitions of two or more states.
    /// </summary>
    /// <typeparam name="T">The type of the class that inherits from StateMachine.</typeparam>
    public class StateMachineBase<T>
    {
        /// <summary>
        /// The current active state.
        /// </summary>
        public BaseState<T> CurrentState;
        /// <summary>
        /// A list of all states that this state machine manages.
        /// </summary>
        /// <returns></returns>
        public List<BaseState<T>> ParallelStates = new();
        /// <summary>
        /// A list of transitions that can happen at any time regardless of the current state.
        /// </summary>
        /// <returns></returns>
        public List<Transition> GlobalTransitions = new();

        public StateMachineBase() { }

        /// <summary>
        /// Check to see if a transition to a next state is available and update the current state.
        /// </summary>
        public virtual void Update()
        {
            if (CurrentState != null)
            {
                var transition = GetTransition();

                if (transition != null)
                {
                    TransitionToState(transition);
                }

                CurrentState?.OnUpdateState();
            }

            foreach (var state in ParallelStates)
            {
                if (state.IsStateActive)
                {
                    state.OnUpdateState();
                }
            }
        }
        public virtual void FixedUpdate()
        {
            if (CurrentState != null)
            {
                CurrentState.OnFixedUpdateState();
            }

            foreach (var state in ParallelStates)
            {
                if (state.IsStateActive)
                {
                    state.OnFixedUpdateState();
                }
            }
        }

        public virtual void AddGlobalTransition(IState to, ICondition condition, Action onTransition = null)
        {
            GlobalTransitions.Add(new Transition(to, condition, onTransition));
        }

        /// <summary>
        /// Checks all available transitions and returns one if its condition is met.
        /// </summary>
        /// <returns>The first transition that has a condition that returns true.</returns>
        public virtual ITransition GetTransition()
        {
            foreach (var transition in GlobalTransitions)
            {
                if (transition.Condition.EvaluateCondition())
                {
                    return transition;
                }
            }
            foreach (var transition in CurrentState.Transitions)
            {
                if (transition.Condition.EvaluateCondition())
                {
                    return transition;
                }
            }
            foreach (var state in ParallelStates)
            {
                if (!state.IsStateActive)
                {
                    continue;
                }

                foreach (var transition in state.Transitions)
                {
                    if (transition.Condition.EvaluateCondition())
                    {
                        return transition;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Exits the current state if one is active, and enters the next state.
        /// </summary>
        /// <param name="transition"></param>
        public void TransitionToState(ITransition transition)
        {
            if (transition.To.GetType() == CurrentState?.GetType())
            {
                return;
            }

            CurrentState?.ExitState();
            transition.OnTransition?.Invoke();
            CurrentState = transition.To as BaseState<T>;
            CurrentState.EnterState();
        }

        public void EnterParallelState(BaseState<T> state)
        {
            if (state.IsStateActive)
            {
                return;
            }

            state.EnterState();
            ParallelStates.Add(state);
        }
        public void ExitParallelState(BaseState<T> state)
        {
            if (!state.IsStateActive)
            {
                return;
            }

            state.ExitState();
            ParallelStates.Remove(state);
        }
    }
}