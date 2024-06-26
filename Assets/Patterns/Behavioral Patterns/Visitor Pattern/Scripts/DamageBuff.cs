using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.VisitorPattern.Example
{
    public class DamageBuff : MonoBehaviour, IVisitable
    {
        public int damage = 0;

        public void Accept(IVisitor visitor)
        {
            Debug.Log("Damage increased!");
            visitor.Visit(this);
        }
    }
}
