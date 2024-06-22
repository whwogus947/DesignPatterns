using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern.Example
{
    public class Bow : IWeapon
    {
        public void Equip()
        {
            Debug.Log("Fitted with a bow");
        }
    }
}
