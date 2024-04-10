using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.VisitorPattern.Example
{
    [CreateAssetMenu(fileName = "Enchant", menuName = "DesignPattern/VisitorPattern/Enchant")]
    public class Enchant : ScriptableObject, IVisitor
    {
        public int damageIncrease;
        public int defenseIncrease;

        public void Visit(DamageBuff visitable)
        {
            visitable.damage += damageIncrease;
        }

        public void Visit(DefenseBuff visitable)
        {
            visitable.defense += defenseIncrease;
        }
    }
}
