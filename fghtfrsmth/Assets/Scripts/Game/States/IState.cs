namespace Game.States
{
    public interface IState : IExitableState
    {
        public void OnEnter();
    }

    public interface IPayloadedState<TPayload> : IExitableState
    {
        public void OnEnter(TPayload payload);
    }

    public interface IExitableState
    {
        public void OnExit();
    }
}