namespace HunterAllen.StateMachine
{
    public interface IStateMachine<T> where T : IStateMachine<T>
    {
        public abstract StateMachineBase<T> StateMachineBase { get; set; }
    }
}