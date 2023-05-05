using System;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private RayController _rayController;

    private void Start()
    {
        _rayController = GetComponentInParent<RayController>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {   
        
        if(col.gameObject.CompareTag($"Ground"))
        {
            _rayController.IsGrounded = true;
        }
        
    }
}