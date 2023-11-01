using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    [CreateAssetMenu(menuName = "Design Patterns/Visitor Pattern/DamageBuff")]
    public class DamageBuff : ObtainableItem
    {
        public int dmgAmount;

        public override void Obatin(FieldPlayer player)
        {
            player.dmg += dmgAmount;
        }
    }
}
