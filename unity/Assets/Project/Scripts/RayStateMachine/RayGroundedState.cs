namespace Raydevs.RayStateMachine
{
    using UnityEngine;
    public class RayGroundedState: RayBaseState
    {
        private static readonly int Grounded = Animator.StringToHash("isGrounded");
        public RayGroundedState(RayStateMachine currentContext, RayStateFactory stateFactory)
            : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            Debug.Log("Entered Grounded State");
            _context.RayAnimator.SetBool(Grounded, true);
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
        }

        public override void CheckSwitchState()
        {
            if (_context.IsJumpPerformed)
            {
                SwitchState(_stateFactory.Jump());
            } else if (_context.IsMoving)
            {
                SwitchState(_stateFactory.Run());
            }
        }
        
    }
}