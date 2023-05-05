using UnityEngine;
using UnityEngine.InputSystem;

namespace Raydevs
{
    public class InteractController : InputManager
    {
        [SerializeField] private GameObject _interactButton;
        private GameObject _existingInteractButton;
        private RayInput _input;
        private bool _isInteractionAvailable = false;
        private bool _isMsgBoxOpen = false;

        protected override void OnInteract(InputAction.CallbackContext ctx)
        {
            if (!_isInteractionAvailable)
            {
                return;
            }
            if (_isMsgBoxOpen)
            {
                // Close msg box
                _isMsgBoxOpen = false;
                return;
            }
            // Open msg box
            OpenMsgBox("Hello");
            
        }
        private void OpenMsgBox(string msg)
        {
            _isMsgBoxOpen = true;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (_existingInteractButton != null || !col.CompareTag(tag: $"Interactable")) return;
            _isInteractionAvailable = true;
            _existingInteractButton = Instantiate(
                original: _interactButton,
                position: transform.position + new Vector3(x: 0, y: 1.5f, z: 0),
                rotation: Quaternion.identity,
                parent: transform);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (_existingInteractButton == null) return;
            Destroy(_existingInteractButton);
            _isInteractionAvailable = false;
        }
    }
}