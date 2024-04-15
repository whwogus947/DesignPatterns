using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    public class Sword :  IWeapon
    {
        public float DamageCoef => 1f;
        public KeyCode Key => KeyCode.Alpha4;

        public void Use(int power)
        {
            SwiftHit();
            Debug.Log($"Damage is {power * DamageCoef}");
        }

        public void SwiftHit()
        {
            Debug.Log("Whoosh!");
        }
    }
}
