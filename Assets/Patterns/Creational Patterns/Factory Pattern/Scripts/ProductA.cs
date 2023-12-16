using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern
{
    public class ProductA : MonoBehaviour, IProduct
    {
        public string SkillName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
