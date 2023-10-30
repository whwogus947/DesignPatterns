using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns
{
    public class Mission : Questable
    {
        public override event UnityAction OnQuestComplete;

        public override void Check()
        {
            if (isCompleted)
            {
                OnQuestComplete?.Invoke();
                gameObject.SetActive(false);
            }
        }
    }
}
