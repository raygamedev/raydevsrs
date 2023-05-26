
namespace Raydevs.RayStateMachine
{
    public class RayCombatStart: RayCombatBaseState
    {
        private int _attackCounter;
        private bool _skipAttack;
        private float timer;

        public RayCombatStart(RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            _context.IsAbleToMove = false;
            if (_context.AttackCounter == 2)
            {
                _skipAttack = true;
            } else
                _context.RayAnimator.Play("LeftPunch");
        }

        public override void UpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            CheckSwitchState();
        }

        public override void FixedUpdateState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
        }

        public override void ExitState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {   
            // Cleanup
            _context.IsAbleToMove = true;
            _context.IsAttackAnimEnded = false;
            if (_context.IsAttackTimerEnded)
            {
                _context.AttackCounter = 0;
            }

        }

        public override void CheckSwitchState()
        {
            if(_skipAttack)
                SwitchState(_stateFactory.CombatCombo());
            else if (_context.IsAttackAnimEnded && _context.AttackCounter == 2)
            {
                SwitchState(_stateFactory.CombatCombo());
            }
            else if(_context.IsAttackTimerEnded || _context.IsAttackAnimEnded)
                SwitchState(_stateFactory.Grounded());
        }
    }
}