using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.FactoryPattern
{
    public interface IProduct
    {
        string SkillName { get; set; }
        void Execute();
    }
}
