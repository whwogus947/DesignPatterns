using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern
{
    public abstract class SkillFactory : MonoBehaviour
    {
        public abstract IProduct GetProduct(Vector3 position);
    }
}
