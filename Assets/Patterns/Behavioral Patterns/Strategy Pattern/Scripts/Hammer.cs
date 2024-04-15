using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    public class Hammer : IWeapon
    {
        public float DamageCoef => 6f;
        public KeyCode Key => KeyCode.Alpha3;

        public void Use(int power)
        {
            Swing();
            Debug.Log($"Damage is {power * DamageCoef}");
        }

        public void Swing()
        {
            Debug.Log("Thud!");
        }
    }
}
