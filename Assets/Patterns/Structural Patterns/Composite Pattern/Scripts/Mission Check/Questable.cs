using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns
{
    public abstract class Questable : MonoBehaviour
    {
        public bool isCompleted = false;

        public abstract event UnityAction OnQuestComplete;
        public abstract void Check();
    }
}
