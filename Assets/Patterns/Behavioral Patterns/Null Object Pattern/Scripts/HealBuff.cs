using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.NullObjectPattern
{
    public class HealBuff : IBuff
    {
        private int value;

        public HealBuff(int value)
        {
            this.value = value;
        }

        public void Enchant(Player player)
        {
            player.HpUp(value);
        }
    }
}
