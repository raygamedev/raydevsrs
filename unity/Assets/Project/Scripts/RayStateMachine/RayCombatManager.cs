using System;
using System.Collections;
using Raydevs.Enemy.EnemyStateMachine;
using Raydevs.VFX;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Scripts.RayStateMachine
{
    public class RayCombatManager: MonoBehaviour
    {
        
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] public Transform SwordAttackPoint;
        [SerializeField] public float SwordAttackRange;
        [SerializeField] public Transform SudoAttackPoint;
        [SerializeField] public LayerMask EnemyLayer;
        [SerializeField] public int LightAttackDamage;
        [SerializeField] private GameObject swordImpactVFX;
        [SerializeField] private GameObject damageText;

        private const float jumpForce = 1000f;
        private const float AttackTimer = 0.7f;
        private const float BattleStanceTimer = 5f;
        
        private Coroutine _attackTimerCoroutine;
        private Coroutine _battleStanceTimerCoroutine;

        public bool HasSword { get; set; } = true;
        public bool HasSudoHammer { get; set; } = true;
        public bool HasReactThrowable { get; set; } = true;
        
        public bool IsLightAttackPerformed { get; set; }
        public bool IsSudoAttackPerformed { get; set; }
        public bool IsReactAttackPerformed { get; set; }
        public bool shouldEnterCombatState;
        public bool IsAnimationEnded { get; set; }

        public bool IsInBattleStance { get; set; }
        public bool IsAttackTimerEnded { get; set; }
        public bool FollowUpAttack { get; set; }
        public bool ComboFinished { get; set; }
        
        public int PressCounter { get; set; }
        private void OnEnable()
        {
            InputManager.OnAttackPressed += OnLightAttack;
            InputManager.OnSudoAttackPressed += OnSudoAttack;
            InputManager.OnReactAttackPressed += OnReactAttack;
        }
        
        private void OnLightAttack(InputAction.CallbackContext ctx)
        {
            IsLightAttackPerformed = ctx.ReadValueAsButton();
            if (!IsLightAttackPerformed) return;

            PressCounter++;
            if (ComboFinished) ComboFinished = false;
            if (!IsAttackTimerEnded && !FollowUpAttack && PressCounter > 1)
                FollowUpAttack = true;
            AttackCooldownResetTimer();
            BattleStanceCooldownResetTimer();
        }
        private void OnSudoAttack(InputAction.CallbackContext ctx)
        {
            if(!HasSudoHammer) return;
            IsSudoAttackPerformed = ctx.ReadValueAsButton();
            if (!IsSudoAttackPerformed) return;
            BattleStanceCooldownResetTimer();
        }

        private void OnReactAttack(InputAction.CallbackContext ctx)
        {
            if(!HasReactThrowable) return;
            IsReactAttackPerformed = ctx.ReadValueAsButton();
            if (!IsReactAttackPerformed) return;
            BattleStanceCooldownResetTimer();
        }

        public void OnAnimationEnd() => IsAnimationEnded = true;
        
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

        public void OnSudoAttackMiniJumpFrameEvent(float force)
        {
            _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
        }

        private void Update()
        {
            shouldEnterCombatState = IsLightAttackPerformed || IsSudoAttackPerformed || IsReactAttackPerformed;
            if(ComboFinished) PressCounter = 0;
        }

        public void SwordHitFrameEvent(int knockBackForce)
        {
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(SwordAttackPoint.position, SwordAttackRange, EnemyLayer);
            foreach (Collider2D enemy in hitEnemies)
            {
                Instantiate(swordImpactVFX, enemy.transform.position, Quaternion.identity);
                GameObject damageTextGameObject = Instantiate(damageText, enemy.transform.position, Quaternion.identity);
                damageTextGameObject.GetComponent<DamageText>().SetDamageText(LightAttackDamage);
                enemy.GetComponent<EnemyController>().TakeDamage(LightAttackDamage, knockBackForce, false);
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(SwordAttackPoint.position, SwordAttackRange);
        }
    }
}