namespace Raydevs
{
    using UnityEngine;
    public class GroundCheck : MonoBehaviour
    {
        private RayStateMachine.RayStateMachine _stateMachine;

        private void Start()
        {
            _stateMachine = GetComponentInParent<RayStateMachine.RayStateMachine>();
        }

        private void OnTriggerStay2D(Collider2D col)
        {

            if (col.gameObject.CompareTag($"Ground"))
            {
                Debug.Log("Grounded");
                _stateMachine.IsGrounded = true;
            }

        }
    }
}