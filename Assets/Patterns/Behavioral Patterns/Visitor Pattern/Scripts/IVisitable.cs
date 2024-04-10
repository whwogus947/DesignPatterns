using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.VisitorPattern.Example
{
    public interface IVisitable
    {
        void Accept(IVisitor visitor);
    }
}
