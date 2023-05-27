namespace Raydevs.RayStateMachine
{
    public class RayGroundedState: RayBaseState
    {
        public RayGroundedState(RayStateMachine currentContext, RayStateFactory stateFactory)
            : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            ctx.MovementManager.IsAbleToMove = true;
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
            if(ctx.CombatManager.IsLightAttackPerformed)
                SwitchState(state.Combat());
            else if(ctx.MovementManager.IsRunning)
                SwitchState(state.Run());
            else if (ctx.MovementManager.IsJumpPerformed)
                SwitchState(state.Jump());
            else SwitchState(state.Idle());
        }
    }
}