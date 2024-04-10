using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.VisitorPattern.Example
{
    public interface IVisitor
    {
        void Visit(DamageBuff visitable);
        void Visit(DefenseBuff visitable);
    }
}
