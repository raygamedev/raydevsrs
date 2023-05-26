using Project.Scripts.RayStateMachine;

namespace Raydevs.RayStateMachine
{
    using UnityEngine;
    public class RayStateMachine : MonoBehaviour
    {
        [SerializeField] public RayMovementManager MovementManager;
        [SerializeField] public RayCombatManager CombatManager;
        [SerializeField] public Animator RayAnimator;
        private RayBaseState _currentState;
        private RayStateFactory _states;

        public string CurrentStateName;

        public RayBaseState CurrentState { get; set; }

        private void Awake()
        {
            _states = new RayStateFactory(this);
            CurrentState = _states.Grounded();
            CurrentState.EnterState(this, _states);
        }

        private void Update()
        {
            CurrentState.UpdateState(this, _states);
            CurrentStateName = CurrentState.GetType().Name;
        }
    }
}

        // public void OnAttackEnd()
        // {
        //     IsAttackAnimEnded = true;
        // }
        // private void OnLightAttackHandler(InputAction.CallbackContext ctx)
        // {
        //     IsLightAttackPerformed = ctx.ReadValueAsButton();
        //     if (IsLightAttackPerformed)
        //     { 
        //         StartOrResetTimer();
        //         if(AttackCounter < 2)
        //             AttackCounter += 1;
        //         else if(HasSword && AttackCounter < 3)
        //             AttackCounter += 1;
        //     }
        //     Debug.Log($"Attack timer ended: {IsAttackTimerEnded}");
        //     Debug.Log($"Attack counter: {AttackCounter}");
        // }
        // void StartOrResetTimer()
        // {
        //     // If timer already started, stop the previous one
        //     if (_attackTimerCoroutine != null)
        //     {
        //         StopCoroutine(_attackTimerCoroutine);
        //     }
        //
        //     _attackTimerCoroutine = StartCoroutine(AttackCooldownTimer());
        // }
        //
        //
        // private IEnumerator AttackCooldownTimer()
        // {
        //     IsAttackTimerEnded = false;
        //     yield return new WaitForSeconds(AttackTimer);
        //     IsAttackTimerEnded = true;
        //     AttackCounter = 0;
        // }
