
namespace Raydevs
{
    using UnityEngine;
    public class Interactable: MonoBehaviour
    {
        public virtual void Interact()
        {
            Debug.Log($"Interacting with {gameObject.name}");
        }

        public virtual void OnInteractLeave()
        {
            Debug.Log($"Leaving Interaction with {gameObject.name}");
        }
    }
}