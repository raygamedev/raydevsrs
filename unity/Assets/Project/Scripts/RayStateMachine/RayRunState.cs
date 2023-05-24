
namespace Raydevs.RayStateMachine
{
    
    using UnityEngine;
    public class RayRunState: RayBaseState
    {
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        public RayRunState(RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            
                _context.RayAnimator.SetBool(IsMoving, true);
        }

        public override void UpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void FixedUpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
        }

        public override void ExitState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
                _context.RayAnimator.SetBool(IsMoving, false);
        }

        public override void CheckSwitchState()
        {
            if(_context.IsMoving== false)
                SwitchState(_stateFactory.Grounded());
            else if (_context.IsJumpPerformed)
                SwitchState(_stateFactory.Jump());
        }
    }
}