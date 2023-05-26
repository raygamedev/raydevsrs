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
            if (ctx.CombatManager.AttackCounter == 2)
                _skipState = true;
            else ctx.RayAnimator.Play("LeftPunch");
            
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
            if (ctx.CombatManager.IsAnimationEnded || _skipState)
            {
                if (ctx.CombatManager.AttackCounter == 2)
                {
                    SwitchState(state.RightPunch());
                }
                else SwitchState(state.Grounded());
            }
            
        }
    }
}