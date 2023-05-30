using System.Collections;
using UnityEngine;

namespace Raydevs.Enemy.EnemyStateMachine.EnemyStates
{
    public class IdleState: EnemyBaseState
    {
        private bool _isIdle;
        public IdleState(EnemyController currentContext, EnemyStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            ctx.IsRunning = false;
            ctx.AnimatorController.Play("Idle");
            ctx.StartCoroutine(StopIdle());
        }

        public override void UpdateState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void ExitState(EnemyController currentContext, EnemyStateFactory stateFactory)
        {
        }

        public override void CheckSwitchState()
        {
            if(ctx.RayDetectedCollider)
                SwitchState(state.Follow());
            if(!_isIdle)
                SwitchState(state.Patrol());
        }
        
        private IEnumerator StopIdle()
        {
            float idleTime = Random.Range(1f, 7f);
            _isIdle = true;
            yield return new WaitForSeconds(idleTime);
            _isIdle = false;
        }
    }
}