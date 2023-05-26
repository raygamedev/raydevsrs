using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Project.Scripts.RayStateMachine
{
    public static class InputManager
    {
        private static RayInput _rayInput;

        static InputManager()
        {
            _rayInput = new RayInput();

            // Enable the input actions
            _rayInput.Enable();
        }

        // Event when the Jump button is pressed
        public static event Action<InputAction.CallbackContext> OnJumpPressed
        {
            add => _rayInput.RayControls.Jump.performed += value;
            remove => _rayInput.RayControls.Jump.performed -= value;
        }

        // Event when the Attack button is pressed
        public static event Action<InputAction.CallbackContext> OnAttackPressed
        {
            add => _rayInput.RayControls.LightAttack.performed += value;
            remove => _rayInput.RayControls.LightAttack.performed -= value;
        }
        
        // Getting the value of the Move action
        public static event Action<InputAction.CallbackContext> OnMove
        {
            add => _rayInput.RayControls.Movement.performed += value;
            remove => _rayInput.RayControls.Movement.performed -= value;
        }
    }
}

//         private void OnEnable()
//         {
//             _rayInput = new RayInput();
//             _rayInput.RayControls.Enable();
//             _rayInput.RayControls.Interactable.performed += OnInteract;
//             _rayInput.RayControls.Movement.performed += OnMove;
//             _rayInput.RayControls.Jump.performed += OnJump;
//         }
//
//         protected virtual void OnInteract(InputAction.CallbackContext ctx){}
//         protected virtual void OnMove(InputAction.CallbackContext ctx){}
//         protected virtual void OnJump(InputAction.CallbackContext ctx){}
//         protected virtual void OnDisable() => _rayInput.Disable();
//     }
// }