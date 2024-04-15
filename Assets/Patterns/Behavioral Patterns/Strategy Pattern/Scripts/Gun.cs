using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    public class Gun : IWeapon
    {
        public Bullet bullet = new();
        public float DamageCoef => 3.2f;
        public KeyCode Key => KeyCode.Alpha2;

        public void Use(int power)
        {
            bullet.ShotBullet(power * DamageCoef);

        }
    }

    public class Bullet
    {
        public void ShotBullet(float damage)
        {
            Debug.Log("Fire!");
            Debug.Log($"Damage is {damage}");
        }
    }
}
