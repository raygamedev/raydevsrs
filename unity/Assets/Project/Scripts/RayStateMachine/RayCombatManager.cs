using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Scripts.RayStateMachine
{
    public class RayCombatManager: MonoBehaviour
    {
        private Coroutine _attackTimerCoroutine;
        private const float AttackTimer = 0.7f;
        public bool AnimEnded;
        public bool IsAnimationEnded { get; set; }
        public bool IsLightAttackPerformed { get; set; }

        public bool IsAttackTimerEnded { get; set; }
        public bool FollowUpAttack { get; set; }
        public bool ComboFinished { get; set; }
        
        public int PressCounter { get; set; }
        private void OnEnable()
        {
            InputManager.OnAttackPressed += OnLightAttack;
        }
        
        private void OnLightAttack(InputAction.CallbackContext ctx)
        {
            IsLightAttackPerformed = ctx.ReadValueAsButton();
            if(IsLightAttackPerformed)
            {
                PressCounter++;
                if (ComboFinished) ComboFinished = false;
                if (!IsAttackTimerEnded && !FollowUpAttack && PressCounter > 1)
                {
                    Debug.Log("Follow up attack");
                    FollowUpAttack = true;
                }
                StartOrResetTimer();
            }
        }

        public void OnAnimationEnd()
        {
            IsAnimationEnded = true;
        }
        
        private void StartOrResetTimer()
        {
            // If timer already started, stop the previous one
            if (_attackTimerCoroutine != null)
            {
                StopCoroutine(_attackTimerCoroutine);
            }
            _attackTimerCoroutine = StartCoroutine(AttackCooldownTimer());
        }
        
        private IEnumerator AttackCooldownTimer()
        {
            IsAttackTimerEnded = false;
            yield return new WaitForSeconds(AttackTimer);
            Debug.Log("Attack timer ended");
            IsAttackTimerEnded = true;
            FollowUpAttack = false;
        }

        private void Update()
        {
            if(ComboFinished) PressCounter = 0;
        }
    }
}