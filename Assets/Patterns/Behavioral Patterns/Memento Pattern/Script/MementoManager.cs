using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.MementoPattern
{
    public class MementoManager : MonoBehaviour
    {
        public Player player;
        public Caretaker caretaker;

        // Save state
        void SaveState()
        {
            Memento memento = player.SaveState();
            caretaker.SaveState(memento);
        }

        // Restore state
        void RestoreState()
        {
            Memento memento = caretaker.GetLastState();
            if (memento != null)
            {
                player.RestoreState(memento);
            }
        }
    }
}
