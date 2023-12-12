using DesignPatterns.NullObjectPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public abstract class Buff : IBuff
    {
        public int value;

        public abstract void Enchant(Player player);
    }
}
