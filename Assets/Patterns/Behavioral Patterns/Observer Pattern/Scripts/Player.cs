using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ObserverPattern.Example
{
    public class Player : MonoBehaviour
    {
        public Observer<int> HP = new(5);

        void Start()
        {
            HP.Invoke();
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                HP.Value += 100;
            }
        }
    }
}
