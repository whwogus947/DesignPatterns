using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.NullObjectPattern
{
    public class DamageBuff : IBuff
    {
        private int value;

        public DamageBuff(int value)
        {
            this.value = value;
        }

        public void Enchant(Player player)
        {
            player.DamageUp(value);
        }
    }
}
