using System;

namespace Game.States
{
    public class LoadLevelState : IPayloadedState<String>
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
    
        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
        }

        public void OnEnter(string sceneName)
        {
            _sceneLoader.Load(sceneName);
        }

        public void OnExit()
        {
        
        }
    }
}