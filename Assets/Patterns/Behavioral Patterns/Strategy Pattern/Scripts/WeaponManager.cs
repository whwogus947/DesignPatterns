using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    [System.Serializable]
    public class WeaponManager
    {
        public IWeapon[] weapons;
        public readonly KeyCode useKey = KeyCode.A;

        private IWeapon currentWeapon;

        public WeaponManager()
        {
            weapons = new IWeapon[]
            {
                new Bow(),
                new Gun(),
                new Hammer(),
                new Sword(),
            };
            currentWeapon = weapons[0];
        }

        public void UseWeapon(int playerDefaultDamage)
        {
            currentWeapon.Use(playerDefaultDamage);
        }

        public void ChangeWeapon()
        {
            foreach (var weapon in weapons)
            {
                if (Input.GetKeyDown(weapon.Key))
                {
                    currentWeapon = weapon;
                    Debug.Log("Weapon Changed!");
                    return;
                }
            }
        }
    }
}
