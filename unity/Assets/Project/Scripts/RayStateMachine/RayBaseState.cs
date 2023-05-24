namespace Raydevs.RayStateMachine
{
    public abstract class RayBaseState
    {
        protected RayStateMachine _context;
        protected RayStateFactory _stateFactory;

        protected RayBaseState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            _context = currentContext;
            _stateFactory = stateFactory;
        }
        public abstract void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory);
        public abstract void UpdateState(RayStateMachine currentContext, RayStateFactory stateFactory);
        public abstract void FixedUpdateState(RayStateMachine currentContext, RayStateFactory stateFactory);
        public abstract void ExitState(RayStateMachine currentContext, RayStateFactory stateFactory);

        public abstract void CheckSwitchState();
        
        protected void SwitchState(RayBaseState newState)
        {
            ExitState(_context, _stateFactory); 
            newState.EnterState(_context, _stateFactory);
            _context.CurrentState = newState;
        }
        
    }
}