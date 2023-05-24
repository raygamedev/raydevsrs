
using System;

namespace Raydevs.RayStateMachine
{
    using UnityEngine;
    using UnityEngine.InputSystem;
    public class RayStateMachine: MonoBehaviour
    {
        
        // public static readonly int IsMoving = Animator.StringToHash("IsMoving");
        // public static readonly int Jump = Animator.StringToHash("Jump");
        // public static readonly int JumpState = Animator.StringToHash("jumpState");
        // public static readonly int Grounded = Animator.StringToHash("isGrounded");
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private Animator _animator;
        
        
        private RayInput _rayInput;
        private RayStateFactory _states;
        
        public float MoveDir { get; set; }
        public bool IsMoving { get; set; }

        public string CurrentStateName;
        
        [SerializeField] public RayBaseState _currentState;
        public RayBaseState CurrentState { get; set; }
        public bool IsJumpPerformed { get; set; }

        public bool IsGrounded { get; set; }
        public Animator RayAnimator => _animator;
        public Rigidbody2D RayRigidbody => _rigidbody2D;
        
        public bool IsFalling => _rigidbody2D.velocity.y < -0.1f;
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
            _rigidbody2D.velocity = new Vector2(MoveDir * _speed, _rigidbody2D.velocity.y);
        }
    }
}