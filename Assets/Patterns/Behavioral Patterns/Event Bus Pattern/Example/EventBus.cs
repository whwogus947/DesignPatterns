using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns.EventBusPattern.Example
{
    public static class EventBus
    {
        private static readonly IDictionary<GameState, UnityEvent> Events = new Dictionary<GameState, UnityEvent>();

        public static void Register(GameState gameState, UnityAction action)
        {
            if (!Events.ContainsKey(gameState))
                Events.Add(gameState, new UnityEvent());

            Events[gameState].AddListener(action);
        }

        public static void Unregister(GameState gameState, UnityAction action)
        {
            if (Events.TryGetValue(gameState, out UnityEvent @event))
            {
                @event.RemoveListener(action);
            }
        }

        public static void Publish(GameState gameState)
        {
            if (Events.TryGetValue(gameState, out UnityEvent @event))
            {
                @event.Invoke();
            }
        }
    }

    public enum GameState
    {
        Preparation,
        Begin,
        Playing,
        End
    }
}
