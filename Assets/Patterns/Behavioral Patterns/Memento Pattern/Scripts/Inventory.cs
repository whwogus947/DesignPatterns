using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.MementoPattern.Example
{
    //this is Originator
    public class Inventory : MonoBehaviour
    {
        public List<Item> inventoryItems = new();

        public Memento CreateMemento()
        {
            var newMemento = new Memento();
            newMemento.SetState(inventoryItems);
            return newMemento;
        }

        public void RestoreMemento(Memento memento)
        {
            inventoryItems = memento.GetState();
        }

        public class Memento
        {
            private List<Item> Items;

            public List<Item> GetState()
            {
                return Items;
            }

            public void SetState(List<Item> items)
            {
                Items = new(items);
            }
        }
    }
}
