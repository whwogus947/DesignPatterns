using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.ServiceLocatorPattern.Example
{
    public interface ISpecialLog
    {
        void Print(string message);
    }

    public interface IRewardSystem
    {
        void SendReward(int reward);
    }
    
    public interface ITimer
    {
        void Tick(float deltaTime);
    }

    public class SpecialLog : ISpecialLog
    {
        public void Print(string message)
        {
            Debug.Log($"<color=red>{message}</color>");
        }
    }

    public class RewardSystem : IRewardSystem
    {
        public void SendReward(int reward)
        {
            Debug.Log("sent somewhere");
        }
    }

    public class Timer : ITimer
    {
        public void Tick(float deltaTime)
        {
            Debug.Log("Time Passed");
        }
    }
}
