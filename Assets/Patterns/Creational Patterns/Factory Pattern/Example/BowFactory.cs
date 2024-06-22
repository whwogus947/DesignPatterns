using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern.Example
{
    public class BowFactory : WeaponFactory
    {
        public override IWeapon CreateAddInventory()
        {
            var bow = new Bow();
            inventory.Add(bow);
            return bow;
        }
    }
}
