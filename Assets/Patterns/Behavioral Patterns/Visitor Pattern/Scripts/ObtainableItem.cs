using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public abstract class ObtainableItem : ScriptableObject
    {
        public abstract void Obatin(FieldPlayer player);
    }
}
