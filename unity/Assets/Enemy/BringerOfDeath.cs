namespace Enemy
{
    using UnityEngine;

    /// <summary>
    /// Bringer of Death first enemy test script.
    /// </summary>
    public class BringerOfDeath : EnemyPatrol
    {
        /*private static readonly int Patrolling = Animator.StringToHash("IsPatrolling");
        private Animator _animator;


        private new void Awake()
        {
            base.Awake();
            _animator = GetComponentInChildren<Animator>();
            // AlertDistance = 2f;
        }

        private new void Update()
        {
            base.Update();
            HandleAttack();
        }

        private void HandleAttack()
        {
            if (IsInAttackRange)
            {
                IsPatrolling = false;
                _animator.SetBool(Patrolling, IsPatrolling);
                _animator.SetBool("IsAttacking", true);
            }
            else
            {
                IsPatrolling = true;
                _animator.SetBool("IsAttacking", false);
                _animator.SetBool(Patrolling, IsPatrolling);
            }
        }*/
    }
}