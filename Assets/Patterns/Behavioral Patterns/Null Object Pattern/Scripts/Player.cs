using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.NullObjectPattern
{
    public class Player : MonoBehaviour
    {
        private int damage = 5;
        private int hp = 100;

        void Start()
        {
            var damageBuff = new DamageBuff(5);
            var healBuff = new HealBuff(5);
            var noBuff = new NoBuff();
        }

        public void DamageUp(int damage)
        {
            this.damage += damage;
        }

        public void HpUp(int hp)
        {
            this.hp += hp;
        }
    }
}
