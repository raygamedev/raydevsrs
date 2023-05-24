using System;

namespace Raydevs
{
    using UnityEngine;
    public class RayAnimator: MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void PlayLightAttack()
        {
            _animator.SetTrigger($"LightAttack");
        }
    }
}