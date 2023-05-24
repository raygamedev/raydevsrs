namespace Raydevs.RayStateMachine
{
    public class RayStateFactory
    {
        RayStateMachine _context;
        public RayStateFactory(RayStateMachine currentContext)
        {
            _context = currentContext;
        }
        
        public RayBaseState Idle()
        {
            return new RayIdleState(_context, this);
        }
        public RayBaseState Run()
        {
            return new RayRunState(_context, this);
        }
        public RayBaseState Jump()
        {
            return new RayJumpState(_context, this);
        }
        public RayBaseState Grounded()
        {
            return new RayGroundedState(_context, this);
        }
    }
}