using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    public class Bow : IWeapon
    {
        public Arrow arrow = new();

        public float DamageCoef => 2f;

        public KeyCode Key => KeyCode.Alpha1;

        public void Use(int power)
        {
            arrow.SingleShot(power * DamageCoef);
        }
    }

    public class Arrow
    {
        public int power;
        public void SingleShot(float damage)
        {
            Debug.Log($"Damage is {damage}");
        }
    }
}
