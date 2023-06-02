namespace Raydevs.Enemy.EnemyStateMachine.EnemyStates
{
    public class TookDamageState: EnemyBaseState
    {
        public TookDamageState(EnemyController currentContext, EnemyStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            ctx.AnimatorController.Play("Damage");
        }

        public override void UpdateState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void ExitState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            ctx.EnemyTookDamage = false;
        }

        public override void CheckSwitchState()
        {
            bool isAnimFinished = ctx.AnimatorController.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
            if(isAnimFinished)
                SwitchState(state.Patrol());
        }
    }
}