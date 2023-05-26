namespace Raydevs.RayStateMachine
{
    public class RayCombatCombo: RayCombatBaseState
    {
        public RayCombatCombo(RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            base.EnterState(currentContext, stateFactory);
            _context.RayAnimator.Play("RightPunch");
        }
        public override void UpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            if (_context.IsAttackAnimEnded)
                CheckSwitchState();
        }

        public override void FixedUpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
        }

        public override void ExitState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            _context.AttackCounter = 0;
        }

        public override void CheckSwitchState()
        {
            if (_context.IsAttackTimerEnded)
            {
                SwitchState(_stateFactory.Grounded());
                return;
            }
            if(_context.AttackCounter == 2 && _context.IsAttackAnimEnded)
                SwitchState(_stateFactory.Grounded());
        }
    }
}