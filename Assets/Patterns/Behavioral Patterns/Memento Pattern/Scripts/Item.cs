using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.MementoPattern.Example
{
    [CreateAssetMenu(fileName = "Item", menuName = "DesignPattern/MementoPattern/Item")]
    public class Item : ScriptableObject
    {
        public string Name;
    }
}
