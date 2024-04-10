using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ServiceLocatorPattern.Example
{
    public class Client : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            ISpecialLog log = new SpecialLog();
            ServiceLocator.Register(log);

            ServiceLocator.Get<ISpecialLog>().Print("Hello World");
        }
    }
}
