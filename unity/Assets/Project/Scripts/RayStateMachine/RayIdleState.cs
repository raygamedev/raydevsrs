using UnityEngine;
using UnityEngine.InputSystem;

namespace Raydevs.RayStateMachine
{
    public class RayIdleState: RayBaseState
    {
        public RayIdleState(RayStateMachine currentContext, RayStateFactory stateFactory) : base(currentContext, stateFactory)
        {
        }

        public override void EnterState(RayStateMachine currentContext, RayStateFactory stateFactory)
        {
            Debug.Log("Entered Idle State");
            
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
        }

        public override void CheckSwitchState()
        {
        }
    }
}