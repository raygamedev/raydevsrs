namespace Raydevs
{
    using System.Collections;
    using UnityEngine;
    // using UnityEngine.InputSystem;
    public class RayController : InputManager {
    /*{
        [SerializeField] private Animator _animator;
        [SerializeField] private Rigidbody2D _rigidbody2D;
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpForce;
        public float RigidbodyY;
        public float raycastDistance = 0.5f;
        private Collider2D _groundCollider;
        private float _moveDir;
        private bool _isMoving;
        private bool _isJumping;

        public bool IsGrounded { get; set; }

        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private static readonly int Jump = Animator.StringToHash("Jump");
        private static readonly int JumpState = Animator.StringToHash("jumpState");
        private static readonly int Grounded = Animator.StringToHash("isGrounded");

        private bool IsFalling => _rigidbody2D.velocity.y < -0.1f;

        private bool IsAboutToHitGround
        {
            get
            {
                Vector2 ray = new Vector2(transform.position.x, transform.position.y - 0.5f);
                RaycastHit2D hit = Physics2D.Raycast(ray,
                    Vector2.down,
                    raycastDistance,
                    LayerMask.GetMask($"Ground"));
                Debug.DrawRay(transform.position, Vector2.down * raycastDistance, Color.red);
                return hit.collider != null;
            }
        }

        protected override void OnMove(InputAction.CallbackContext ctx)
        {
            _moveDir = ctx.ReadValue<float>();
            _isMoving = _moveDir != 0;
        }

        protected override void OnJump(InputAction.CallbackContext ctx)
        {
            _isJumping = ctx.ReadValueAsButton();
        }
        // Update is called once per frame
        private void Update()
        {
            HandleInput();
            Flip();
            if (IsFalling)
            {
                IsGrounded = false;
                _animator.SetFloat(JumpState, 2);
            }
            _animator.SetBool(Grounded, IsGrounded);
        }

        private void FixedUpdate()
        {
            _rigidbody2D.velocity = new Vector2(_moveDir * _speed, _rigidbody2D.velocity.y);

        }

        private void Flip()
        {
            switch (_moveDir)
            {
                case < 0 when transform.localScale.x > 0:
                case > 0 when transform.localScale.x < 0:
                    transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y,
                        transform.localScale.z);
                    break;
            }
        }

        private void HandleInput()
        {
            if (!_isJumping)
            {
                _animator.SetBool(IsMoving, _isMoving);
            }

            HandleJump();
        }

        private void HandleJump()
        {
            if (!IsGrounded)
                if (IsAboutToHitGround && IsFalling)
                    _animator.SetFloat(JumpState, 3);
                else
                    _animator.SetFloat(JumpState, IsFalling ? 2 : 1);

            if (IsFalling && IsGrounded)
            {
                _animator.SetFloat(JumpState, 4);
                StartCoroutine(DelayAction(1f));
            }

            if (!_isJumping || !IsGrounded) return;
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);
            IsGrounded = false;
            _animator.SetBool(Jump, true);
        }

        private IEnumerator DelayAction(float delayTime)
        {
            yield return new WaitForSeconds(delayTime);
            if (IsGrounded)
                _animator.SetFloat(JumpState, 0);
        }*/
    }
}