using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.StrategyPattern.Example
{
    public interface IWeapon
    {
        KeyCode Key { get; }
        float DamageCoef { get; }
        void Use(int power);
    }
}
