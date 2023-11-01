using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public class FieldPlayer : MonoBehaviour
    {
        public int hp;
        public int mp;
        public int dmg;
        public int level;
        public int exp;

        public void GetItem(Collider item)
        {
            if (item.TryGetComponent<InteractableWorldItem>(out var worldItem))
            {
                worldItem.obtainableItem.Obatin(this);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            GetItem(other);
        }
    }
}
