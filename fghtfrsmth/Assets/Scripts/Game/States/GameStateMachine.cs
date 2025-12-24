using System;
using System.Collections.Generic;

namespace Game.States
{
    public class GameStateMachine
    {
        private readonly Dictionary<Type, IExitableState> _states;
        private IExitableState _currentState;

        public GameStateMachine(SceneLoader sceneLoader)
        {
            _states = new Dictionary<Type, IExitableState>()
            {
                [typeof(BootstrapState)] = new BootstrapState(this, sceneLoader),
                [typeof(LoadLevelState)] = new LoadLevelState(this, sceneLoader)
            };
        }

        public void Enter<TState>() where TState : class, IState
        {
            _currentState?.OnExit();
            IState state = GetState<TState>();
            _currentState = state;
            state.OnEnter();
        }

        public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
        {
            _currentState?.OnExit();
            IPayloadedState<TPayload> state = GetState<TState>();
            _currentState = state;
            state.OnEnter(payload);
        }

        private TState GetState<TState>() where TState : class, IExitableState =>
            _states[typeof(TState)] as TState;
    }
}