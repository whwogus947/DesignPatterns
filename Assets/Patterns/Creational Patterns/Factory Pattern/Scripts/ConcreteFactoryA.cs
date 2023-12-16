using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern
{
    public class ConcreteFactoryA : SkillFactory
    {
        public ProductA product;

        public override IProduct GetProduct(Vector3 position)
        {
            var clone = Instantiate(product);
            clone.Execute();
            return clone;
        }
    }
}
