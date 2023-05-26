using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Scripts.RayStateMachine
{
    public class RayCombatManager: MonoBehaviour
    {
        private Coroutine _attackTimerCoroutine;
        private const float AttackTimer = 0.7f;
        public bool IsAnimationEnded { get; set; }
        public bool IsLightAttackPerformed { get; set; }
        public int AttackCounter { get; set; } = 0;


        public bool IsAttackTimerEnded { get; set; }
        private void OnEnable()
        {
            InputManager.OnAttackPressed += OnLightAttack;
        }
        
        private void OnLightAttack(InputAction.CallbackContext ctx)
        {
            IsLightAttackPerformed = ctx.ReadValueAsButton();
            if(IsLightAttackPerformed)
            { 
                StartOrResetTimer();
                if(AttackCounter < 2)
                    AttackCounter++;
            }
            Debug.Log($"Attack counter: {AttackCounter}");
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
            AttackCounter = 0;
        }

    }
}