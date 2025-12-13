using Game;
using UnityEngine;

public class BootstrapState : IState
{
    private const string InitialSceneName = "Initial";
    private readonly GameStateMachine _stateMachine;
    private readonly SceneLoader _sceneLoader;
    
    public BootstrapState(GameStateMachine stateMachine, SceneLoader sceneLoader)
    {
        _stateMachine = stateMachine;
        _sceneLoader = sceneLoader;
    }

    public void OnEnter()
    {
        RegisterServices();
        _sceneLoader.Load(InitialSceneName, EnterLoadLevel);
    }

    private void EnterLoadLevel()
    {
        
    }

    private void RegisterServices()
    {
        
    }

    public void OnExit()
    {
        
    }
}