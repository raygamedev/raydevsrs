using System;
using UnityEngine;

public class InteractController : MonoBehaviour
{
    [SerializeField] private GameObject _interactButton;
    private GameObject _existingInteractButton;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (_existingInteractButton == null && col.CompareTag(tag: $"Interactable"))
        {
            _existingInteractButton = Instantiate(
                original: _interactButton,
                position: transform.position + new Vector3(x: 0,y: 1.5f,z: 0),
                rotation: Quaternion.identity,
                parent: transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(_existingInteractButton != null)
            Destroy(_existingInteractButton);
    }
}
