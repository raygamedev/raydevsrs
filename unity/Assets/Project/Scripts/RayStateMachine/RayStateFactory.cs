
using Project.Scripts.RayStateMachine.CombatStates;

namespace Raydevs.RayStateMachine
{
    public class RayStateFactory
    {
        private readonly RayStateMachine _context;
        public RayStateFactory(RayStateMachine currentContext)
        {
            _context = currentContext;
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
        public RayBaseState Combat()
        {
            return new RayCombatState(_context, this);
        }
        public RayBaseState LeftPunch()
        {
            return new RayLeftPunchState(_context, this);
        }
        public RayBaseState RightPunch()
        {
            return new RayRightPunchState(_context, this);
        }
    }
}