using UnityEngine;

namespace Raydevs.RayStateMachine
{
    public class RayJumpState : RayBaseState
    {
        
        private static readonly int JumpState = Animator.StringToHash("jumpState");
        public static readonly int Jump = Animator.StringToHash("Jump");
        public RayJumpState(RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            HandleJump();
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
            if (_context.IsGrounded)
            {
                SwitchState(_stateFactory.Grounded());
            }
        }
        
        private void HandleJump()
        {
            if (_context.IsAboutToHitGround && _context.IsFalling)
                _context.RayAnimator.SetFloat(JumpState, 3);
            else if (_context.IsAboutToHitGround)
                _context.RayAnimator.SetFloat(JumpState, _context.IsFalling ? 2 : 1);
            _context.RayRigidbody.AddForce(Vector2.up * 2000, ForceMode2D.Force);
            _context.IsGrounded = false;
            // _context.RayAnimator.SetBool(Jump, true);
            
        }
    }
}
// if (IsFalling && IsGrounded)
// {
//     _context.Animator.SetFloat(JumpState, 4);
//     StartCoroutine(DelayAction(1f));
// }
