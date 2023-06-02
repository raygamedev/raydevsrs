using System;
using UnityEngine;
using TMPro;

namespace Raydevs.VFX
{
    public class DamageText: MonoBehaviour
    {
        [SerializeField] private float destroyTime = 0.3f;
        [SerializeField] private Vector3 Offset = new Vector3(0, 2, 0);
        [SerializeField] private TextMeshPro _textMeshPro;

        private void Start()
        {
            Destroy(gameObject, destroyTime);
            transform.localPosition += Offset;
        }
        public void SetDamageText(int damageAmount)
        {
            _textMeshPro.SetText(damageAmount.ToString());
            gameObject.SetActive(true);
        }

    }
}