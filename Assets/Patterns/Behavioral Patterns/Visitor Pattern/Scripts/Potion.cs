using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    [CreateAssetMenu(menuName = "Design Patterns/Visitor Pattern/Potion")]
    public class Potion : ObtainableItem
    {
        public int hpAmount;

        public override void Obatin(FieldPlayer player)
        {
            player.hp += hpAmount;
        }
    }
}
