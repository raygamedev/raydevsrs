using Raydevs.RayStateMachine;

namespace Project.Scripts.RayStateMachine.CombatStates
{
    public class RaySwingContinuerState: RayBaseState

    {
        public RaySwingContinuerState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            ctx.RayAnimator.Play("SwingContinuer");
        }

        public override void UpdateState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void ExitState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            ctx.CombatManager.IsAnimationEnded = false;
        }

        public override void CheckSwitchState()
        {
            if (ctx.CombatManager.IsAnimationEnded && ctx.CombatManager.FollowUpAttack)
                SwitchState(state.SwingFinisher());
            else if (ctx.CombatManager.IsAnimationEnded)
                SwitchState(state.Combat());
        }
    }
}