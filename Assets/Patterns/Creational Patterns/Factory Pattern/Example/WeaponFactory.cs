using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern.Example
{
    public abstract class WeaponFactory : MonoBehaviour
    {
        public static List<IWeapon> inventory = new();
        public abstract IWeapon CreateAddInventory();
    }
}
