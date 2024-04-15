using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    public class Player : MonoBehaviour
    {
        public int defaultDamage = 10;
        public WeaponManager weaponManager;

        private void Start()
        {
            weaponManager = new WeaponManager();
        }

        void Update()
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(weaponManager.useKey))
                    weaponManager.UseWeapon(defaultDamage);
                else
                    weaponManager.ChangeWeapon();
            }
        }
    }
}
