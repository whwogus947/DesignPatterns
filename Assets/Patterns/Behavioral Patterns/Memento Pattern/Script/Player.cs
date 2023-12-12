using System;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.MementoPattern
{
    public class Player : MonoBehaviour
    {
        private int health;

        public void SetHealth(int value)
        {
            health = value;
        }

        public Memento SaveState()
        {
            return new Memento { health = health };
        }

        public void RestoreState(Memento memento)
        {
            health = memento.health;
        }
    }
}
