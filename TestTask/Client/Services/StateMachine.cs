using System;

namespace TestTask.Client.Services
{
    /// <summary>
    /// "Машина состояний"
    /// </summary>
    public class StateMachine
    {
        public enum State
        {
            Idle, Add, Change, Delete
        }

        public StateMachine()
        {
            CurrentState = State.Idle;
        }

        public State CurrentState { get; private set; }

        public event Action<State> StateChanged; 

        public void SetIdleState()
        {
            CurrentState = State.Idle;
            StateChanged?.Invoke(CurrentState);
        }

        public void SetAddState()
        {
            CurrentState = State.Add;
            StateChanged?.Invoke(CurrentState);
        }

        public void SetChangeState()
        {
            CurrentState = State.Change;
            StateChanged?.Invoke(CurrentState);
        }
        public void SetDeleteState()
        {
            CurrentState = State.Delete;
            StateChanged?.Invoke(CurrentState);
        }
    }
}