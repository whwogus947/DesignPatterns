using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern.Example
{
    public class SwordFactory : WeaponFactory
    {
        public override IWeapon CreateAddInventory()
        {
            var sword = new Sword();
            inventory.Add(sword);
            return sword;
        }
    }
}
