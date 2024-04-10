using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DesignPatterns.ObserverPattern.Example
{
    public class Display : MonoBehaviour
    {
        public TMP_Text health;

        void Start()
        {
            health = GetComponent<TMP_Text>();
        }

        public void UpdateDisplay(int health)
        {
            this.health.text = health.ToString();
        }
    }
}
