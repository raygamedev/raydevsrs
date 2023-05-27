using Raydevs.RayStateMachine;

namespace Project.Scripts.RayStateMachine.CombatStates
{
    public class RayLeftPunchState: RayBaseState
    {
        private bool _skipState;
        public RayLeftPunchState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            
            ctx.MovementManager.IsAbleToMove = false;
            _skipState = ctx.CombatManager.FollowUpAttack && !ctx.CombatManager.IsAttackTimerEnded;
            if (_skipState) return;
            ctx.RayAnimator.Play(ctx.HasSword ? "LightAttack_1": "LeftPunch");
            
        }

        public override void UpdateState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void ExitState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            ctx.CombatManager.IsAnimationEnded = false;
            ctx.MovementManager.IsAbleToMove = true;
        }

        public override void CheckSwitchState()
        {
            if (_skipState) SwitchState(state.RightPunch());
            else if(ctx.CombatManager.IsAnimationEnded && ctx.CombatManager.FollowUpAttack)
                SwitchState(state.RightPunch());
            else if(ctx.CombatManager.IsAnimationEnded)
                SwitchState(state.Combat());
        }
    }
}