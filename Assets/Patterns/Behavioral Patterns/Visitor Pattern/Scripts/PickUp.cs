using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.VisitorPattern.Example
{
    public class PickUp : MonoBehaviour
    {
        public Enchant enchant;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IVisitable player))
            {
                player.Accept(enchant);
            }
            Destroy(gameObject);
        }
    }
}
