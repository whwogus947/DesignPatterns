using DesignPatterns.NullObjectPattern;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns
{
    public static class BuffExtensions
    {
        public static IBuff Create(this Buff buff)
        {
            return buff;
        }
    }
}
