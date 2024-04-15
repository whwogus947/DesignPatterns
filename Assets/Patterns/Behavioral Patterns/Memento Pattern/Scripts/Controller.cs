using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.MementoPattern.Example
{
    //this is Caretaker
    public class Controller : MonoBehaviour
    {
        public Inventory inventory;
        public Button saveButton;
        public Button cancelButton;

        private Stack<Inventory.Memento> mementos = new();

        void Start()
        {
            saveButton.onClick.AddListener(Save);
            cancelButton.onClick.AddListener(Cancel);
        }

        private void Save()
        {
            var newMemento = inventory.CreateMemento();
            mementos.Push(newMemento);
        }

        private void Cancel()
        {
            if (mementos.Count <= 0)
                return;

            var memento = mementos.Pop();
            inventory.RestoreMemento(memento);
        }
    }
}
