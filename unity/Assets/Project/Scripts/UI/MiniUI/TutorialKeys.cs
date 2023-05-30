using System;
using UnityEngine;

namespace Raydevs.UI.MiniUI
{
    public class TutorialKeys : UnityEngine.MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag($"Player"))
            {
                Destroy(gameObject);
            }
        }
    }
}