using System;
using UnityEditor;
using UnityEngine;

namespace Raydevs.Enemy.EnemyStateMachine
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] public Rigidbody2D rigidbody;
        [SerializeField] public Animator AnimatorController;
        [SerializeField] public float AlertDistance = 3f;
        [SerializeField] public float AttackDistance = 1f;
        public string CurrentStateName;

        private EnemyBaseState _currentState;
        private EnemyStateFactory _states;
        
        public EnemyBaseState CurrentState { get; set; }
        public int Direction { get; set; }
        public float MoveSpeed { get; set; } = 100f;
        public bool IsRunning { get; set; }
        public bool IsAbleToMove { get; set; } = true;

        public bool IsInAttackRange =>
            Physics2D.Raycast(
                origin: transform.position,
                direction: new Vector2(x: Direction, y: 0),
                distance: AttackDistance,
                layerMask: LayerMask.GetMask("Ray")).collider != null;

        public bool RayDetectedCollider =>
            Physics2D.Raycast(
                origin: transform.position,
                direction: new Vector2(x: Direction, y: 0),
                distance: AlertDistance,
                layerMask: LayerMask.GetMask("Ray")).collider != null;


        private void Awake()
        {
            Direction = transform.localScale.x > 0 ? 1 : -1;
            _states = new EnemyStateFactory(this);
            CurrentState = _states.Patrol();
            CurrentState.EnterState(this, _states);
        }
        

        private void Update()
        {
            CurrentState.UpdateState(this, _states);
            CurrentStateName = CurrentState.GetType().Name;
        }

        private void FixedUpdate()
        {
            if (IsRunning && IsAbleToMove)
                rigidbody.velocity =
                    new Vector2(Direction * MoveSpeed * Time.deltaTime, rigidbody.velocity.y);
        }

        public void Flip()
        {
            Direction *= -1;
            transform.localScale = new Vector3(
                x: Direction,
                y: transform.localScale.y,
                z: transform.localScale.z);
        }
    }
}