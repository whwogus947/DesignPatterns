using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.VisitorPattern.Example
{
    public class DefenseBuff : MonoBehaviour, IVisitable
    {
        public int defense = 0;

        public void Accept(IVisitor visitor)
        {
            Debug.Log("Defense Increased!");
            visitor.Visit(this);
        }
    }
}
