using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern.Example
{
    public class Example : MonoBehaviour
    {
        Test test1 = new Test();

        void Start()
        {
            SetNull(test1);
            Debug.Log(test1);
        }

        public void SetNull(Test test)
        {
            test = null;
        }
    }

    public class Test
    {
        public string Name { get; set; }
    }
}
