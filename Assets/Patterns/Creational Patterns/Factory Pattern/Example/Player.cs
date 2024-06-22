using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern.Example
{
    public class Player : MonoBehaviour
    {
        public WeaponFactory weaponFactory;
        private IWeapon weapon;

        void Start()
        {
            weapon = weaponFactory.CreateAddInventory();
            weapon.Equip();
        }
    }
}
