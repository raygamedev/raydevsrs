using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Scripts.RayStateMachine
{
    public class RayCombatManager: MonoBehaviour
    {
        
        [SerializeField] private Rigidbody2D _rigidbody;
        private Coroutine _attackTimerCoroutine;
        private Coroutine _battleStanceTimerCoroutine;
        private const float AttackTimer = 0.7f;
        private const float BattleStanceTimer = 5f;
        public bool AnimEnded;
        public bool IsAnimationEnded { get; set; }
        public bool IsLightAttackPerformed { get; set; }
        public bool IsInBattleStance { get; set; }
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
                AttackCooldownResetTimer();
                BattleStanceCooldownResetTimer();
            }
        }

        public void OnAnimationEnd()
        {
            IsAnimationEnded = true;
        }
        
        private void AttackCooldownResetTimer()
        {
            // If timer already started, stop the previous one
            if (_attackTimerCoroutine != null)
            {
                StopCoroutine(_attackTimerCoroutine);
            }
            _attackTimerCoroutine = StartCoroutine(AttackCooldownTimer());
        }
        
        private void BattleStanceCooldownResetTimer()
        {
            // If timer already started, stop the previous one
            if (_battleStanceTimerCoroutine != null)
            {
                StopCoroutine(_battleStanceTimerCoroutine);
            }
            _battleStanceTimerCoroutine = StartCoroutine(BattleStanceCooldownTimer());
        }
        private IEnumerator AttackCooldownTimer()
        {
            IsAttackTimerEnded = false;
            yield return new WaitForSeconds(AttackTimer);
            Debug.Log("Attack timer ended");
            IsAttackTimerEnded = true;
            FollowUpAttack = false;
        }
        
        private IEnumerator BattleStanceCooldownTimer()
        {
            IsInBattleStance = true;
            yield return new WaitForSeconds(BattleStanceTimer);
            IsInBattleStance = false;
        }
        private Vector2 GetMoveDirection()
        {
            return transform.localScale.x > 0 ? Vector2.right : Vector2.left;
        }

        public void OnMoveForward(float force)
        {
            _rigidbody.AddForce(GetMoveDirection() * force, ForceMode2D.Impulse);
        }

        private void Update()
        {
            if(ComboFinished) PressCounter = 0;
        }
    }
}