using UnityEngine;

namespace Raydevs.Enemy.EnemyStateMachine.EnemyStates
{
    public class AttackState: EnemyBaseState
    {
        private bool _isAnimFinished;
        public AttackState(EnemyController currentContext, EnemyStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            ctx.IsAbleToMove = false;
            ctx.AnimatorController.Play("Attack");
        }

        public override void UpdateState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            _isAnimFinished = ctx.AnimatorController.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
            CheckSwitchState();
        }

        public override void ExitState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            ctx.IsAbleToMove = true;
        }

        public override void CheckSwitchState()
        {
            if(ctx.EnemyTookDamage)
                SwitchState(state.TookDamage());
            else if(!ctx.IsInAttackRange && _isAnimFinished)
                SwitchState(state.Follow());
        }
    }
}