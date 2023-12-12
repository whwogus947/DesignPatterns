using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public class Caretaker : MonoBehaviour
    {
        private List<Memento> mementos = new List<Memento>();

        public void SaveState(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento GetLastState()
        {
            if (mementos.Count > 0)
            {
                Memento lastState = mementos[mementos.Count - 1];
                mementos.RemoveAt(mementos.Count - 1);
                return lastState;
            }
            else
            {
                return null;
            }
        }
    }
}
