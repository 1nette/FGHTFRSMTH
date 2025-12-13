using System;
using System.Collections.Generic;
using Game;

public class GameStateMachine
{
    private readonly Dictionary<Type, IState> _states;
    private IState _currentState;

    public GameStateMachine(SceneLoader sceneLoader)
    {
        _states = new Dictionary<Type, IState>()
        {
            [typeof(BootstrapState)] = new BootstrapState(this, sceneLoader)
        };
    }

    public void Enter<TState>() where TState : IState
    {
        _currentState?.OnExit();
        _currentState = _states[typeof(TState)];
        _currentState.OnEnter();
    }
}