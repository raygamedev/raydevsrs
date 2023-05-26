namespace Raydevs.RayStateMachine
{
    using UnityEngine;
    using System.Collections;
    using UnityEngine.InputSystem;

    public class RayStateMachine : MonoBehaviour
    {
        private const float AttackTimer = 0.70f;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private Animator _animator;
        [SerializeField] public RayBaseState _currentState;
        private Coroutine _attackTimerCoroutine;
        private RayInput _rayInput;
        private RayStateFactory _states;
        private bool _hasSword;

        public float MoveDir { get; set; }
        public bool IsMoving { get; set; }

        public bool IsAbleToMove { get; set; } = true;

        public string CurrentStateName;

        public RayBaseState CurrentState { get; set; }
        public bool IsJumpPerformed { get; set; }

        public bool IsGrounded { get; set; }
        public bool IsLightAttackPerformed { get; set; }
        public bool IsHeavyAttackPerformed { get; set; }
        
        public bool IsAttackAnimEnded { get; set; }
        public bool IsAttackTimerEnded { get; set; }
        public bool IsAttackEnabled { get; set; } = true;

        public Animator RayAnimator => _animator;
        public Rigidbody2D RayRigidbody => _rigidbody2D;

        public bool IsFalling => _rigidbody2D.velocity.y < -0.1f;

        public int AttackCounter { get; set; }

        public void OnAttackEnd()
        {
            IsAttackAnimEnded = true;
        }

        // TODO: Add falling state
        public bool IsAboutToHitGround
        {
            get
            {
                const float raycastDistance = 0.5f;
                Vector2 ray = new Vector2(transform.position.x, transform.position.y - 0.5f);
                RaycastHit2D hit = Physics2D.Raycast(ray,
                    Vector2.down,
                    raycastDistance,
                    LayerMask.GetMask($"Ground"));
                Debug.DrawRay(transform.position, Vector2.down * raycastDistance, Color.red);
                return hit.collider != null;
            }
        }

        private void Flip()
        {
            switch (MoveDir)
            {
                case < 0 when transform.localScale.x > 0:
                case > 0 when transform.localScale.x < 0:
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,
                        transform.localScale.z);
                    break;
            }
        }

        private void OnEnable()
        {
            _rayInput = new RayInput();
            _rayInput.RayControls.Enable();
            _rayInput.RayControls.Interactable.performed += OnInteract;
            _rayInput.RayControls.Movement.performed += OnMove;
            _rayInput.RayControls.Jump.performed += OnJump;
            _rayInput.RayControls.LightAttack.performed += OnLightAttackHandler;
            _rayInput.RayControls.HeavyAttack.performed += ctx => IsHeavyAttackPerformed = ctx.ReadValueAsButton();
        }

        private void OnLightAttackHandler(InputAction.CallbackContext ctx)
        {
            IsLightAttackPerformed = ctx.ReadValueAsButton();
            if (IsLightAttackPerformed)
            { 
                StartOrResetTimer();
                if(AttackCounter < 2)
                    AttackCounter += 1;
            }
            Debug.Log($"Attack timer ended: {IsAttackTimerEnded}");
            Debug.Log($"Attack counter: {AttackCounter}");
        }

        public void OnInteract(InputAction.CallbackContext ctx)
        {
        }

        private void OnMove(InputAction.CallbackContext ctx)
        {
            MoveDir = ctx.ReadValue<float>();
            IsMoving = MoveDir != 0;
        }

        private void OnJump(InputAction.CallbackContext ctx) => IsJumpPerformed = ctx.ReadValueAsButton();

        private void OnDisable() => _rayInput.Disable();

        private void Awake()
        {
            _states = new RayStateFactory(this);
            CurrentState = _states.Grounded();
            CurrentState.EnterState(this, _states);
        }

        private void Update()
        {
            Flip();
            CurrentState.UpdateState(this, _states);
            CurrentStateName = CurrentState.GetType().Name;
        }

        private void FixedUpdate()
        {
            CurrentState.FixedUpdateState(this, _states);
            float _speed = 5f;
            if (IsAbleToMove)
                _rigidbody2D.velocity = new Vector2(MoveDir * _speed, _rigidbody2D.velocity.y);
        }

        void StartOrResetTimer()
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
            IsAttackTimerEnded = true;
            AttackCounter = 0;
        }

        

     
    }
}