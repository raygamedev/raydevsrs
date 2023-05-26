using UnityEngine;

namespace Raydevs.RayStateMachine
{
    public class RayJumpState : RayBaseState
    {
        
        private static readonly int JumpState = Animator.StringToHash("jumpState");
        public static readonly int Jump = Animator.StringToHash("Jump");
        public RayJumpState(RayStateMachine currentContext, RayStateFactory stateFactory) 
            : base(currentContext, stateFactory) {}

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            HandleJump();
        }

        public override void UpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void ExitState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
        }

        public override void CheckSwitchState()
        {
            if (ctx.MovementManager.IsRunning)
                SwitchState(state.Run());
            else if (ctx.MovementManager.IsGrounded)
            {
                SwitchState(state.Grounded());
            }
        }
        
        private void HandleJump()
        {
            // if (ctx.MovementManager.IsAboutToHitGround && ctx.MovementManager.IsFalling)
            //     ctx.RayAnimator.SetFloat(JumpState, 3);
            // else if (ctx.MovementManager.IsAboutToHitGround)
            //     ctx.RayAnimator.SetFloat(JumpState, ctx.MovementManager ? 2 : 1);
            if (ctx.MovementManager.IsAirborne == false)
            {
                ctx.MovementManager.IsGrounded = false;
                ctx.MovementManager.Rigidbody.AddForce(Vector2.up * 2000, ForceMode2D.Force);
            }
            // ctx.RayAnimator.SetBool(Jump, true);
            
        }
    }
}
// if (IsFalling && IsGrounded)
// {
//     ctx.Animator.SetFloat(JumpState, 4);
//     StartCoroutine(DelayAction(1f));
// }
