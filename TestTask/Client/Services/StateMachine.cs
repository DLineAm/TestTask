﻿using Blazored.SessionStorage;

using System;

namespace TestTask.Client.Services
{
    /// <summary>
    /// "Машина состояний"
    /// </summary>
    public class StateMachine
    {
        private readonly ISyncSessionStorageService _storageService;

        public enum State
        {
            Idle, Add, Change, Delete
        }

        public StateMachine(ISyncSessionStorageService storageService)
        {
            _storageService = storageService;
            CurrentState = GetState();
        }

        public State CurrentState { get; private set; }

        public event Action<State> StateChanged; 

        public void SetIdleState()
        {
            CurrentState = State.Idle;
            SaveStateToSession();
            StateChanged?.Invoke(CurrentState);
        }

        public void SetAddState()
        {
            CurrentState = State.Add;
            SaveStateToSession();
            StateChanged?.Invoke(CurrentState);
        }

        public void SetChangeState()
        {
            CurrentState = State.Change;
            SaveStateToSession();
            StateChanged?.Invoke(CurrentState);
        }
        public void SetDeleteState()
        {
            CurrentState = State.Delete;
            SaveStateToSession();
            StateChanged?.Invoke(CurrentState);
        }

        private void SaveStateToSession()
        {
            _storageService.SetItem("state", CurrentState.ToString());
        }

        private State GetState()
        {
            return _storageService.GetItem<State>("state");
        }
    }
}