using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

public class RayController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _rayMass = 78;
    public float RigidbodyY;
    public float raycastDistance = 0.5f;
    private RayInput _input;
    private Collider2D _groundCollider;
    
    
    private bool _isMoving;
    private bool _isJumping;
    
    public bool IsGrounded { get; set; }
    
    private static readonly int IsMoving = Animator.StringToHash("IsMoving");
    private static readonly int IsJumping = Animator.StringToHash("IsJumping");
    private static readonly int Jump = Animator.StringToHash("Jump");
    private static readonly int JumpState = Animator.StringToHash("jumpState");
    private static readonly int Grounded = Animator.StringToHash("isGrounded");

    private bool IsFalling => _rigidbody2D.velocity.y < -0.1f;
    private bool IsAboutToHitGround {
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
    
    private void Awake()
    {
        _rigidbody2D.mass = _rayMass;
        _input = new RayInput();
    }

    private void OnEnable()
    {
        _input.RayControls.Enable();
        _input.RayControls.Movement.performed += ctx =>
        {
            _moveDir = ctx.ReadValue<float>();
            _isMoving = _moveDir != 0;
        };
        _input.RayControls.Jump.performed += ctx => _isJumping = ctx.ReadValueAsButton();
    }

    private void OnDisable()
    {
        _input.RayControls.Disable();
    }


    // Update is called once per frame
    private void Update()
    {
        HandleInput();
        Flip();
        _animator.SetBool(Grounded, IsGrounded);
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(_moveDir * _speed, _rigidbody2D.velocity.y);
        
    }

    private void LateUpdate()
    {
    }


    private void Flip()
    {
        switch (_moveDir)
        {
            case < 0 when transform.localScale.x > 0:
            case > 0 when transform.localScale.x < 0:
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
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
        if(!IsGrounded)
            if (IsAboutToHitGround && IsFalling)
                _animator.SetFloat(JumpState, 3);
            else
                
                _animator.SetFloat(JumpState, IsFalling ? 2 : 1);
        
        if (IsFalling && IsGrounded)
        {
            _animator.SetFloat(JumpState,4);
            StartCoroutine(DelayAction(1f));
        }
        
        if (!_isJumping || !IsGrounded) return;
        _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);
        IsGrounded = false;
        _animator.SetBool(Jump, true);
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        if(IsGrounded)
            _animator.SetFloat(JumpState,0);
    }
}