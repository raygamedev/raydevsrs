using Raydevs.RayStateMachine;
using UnityEngine;

namespace Project.Scripts.RayStateMachine.CombatStates
{
    public class RayRightPunchState: RayBaseState
    {
        public RayRightPunchState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            Debug.Log("Entered");
            ctx.RayAnimator.Play("RightPunch");
        }

        public override void UpdateState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void ExitState(Raydevs.RayStateMachine.RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            ctx.CombatManager.IsAnimationEnded = false;
            ctx.CombatManager.AttackCounter = 0;
        }

        public override void CheckSwitchState()
        {
            if(ctx.CombatManager.IsAnimationEnded || ctx.CombatManager.IsAttackTimerEnded)
                SwitchState(state.Grounded());
        }
    }
}