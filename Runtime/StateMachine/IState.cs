using System.Collections.Generic;

namespace HunterAllen.StateMachine
{
    public interface IState
    {
        public bool IsStateActive { get; set; }
        public List<ITransition> Transitions { get; set; }
        
        public abstract void EnterState();
        public abstract void OnEnterState();
        public abstract void OnUpdateState();
        public abstract void OnFixedUpdateState();
        public abstract void ExitState();
        public abstract void OnExitState();
    }
}