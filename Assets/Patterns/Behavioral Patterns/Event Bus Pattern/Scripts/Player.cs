using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.EventBusPattern.Example
{
    public class Player : MonoBehaviour
    {

        EventBinding<TestEvent> testEventBinding;
        EventBinding<PlayerEvent> playerEventBinding;
        EventBinding<PlayerEvent> nextEventBinding;

        PlayerEvent temp;

        private void OnEnable()
        {
            testEventBinding = new(HandleTestEvent);
            EventBus<TestEvent>.Register(testEventBinding);
            playerEventBinding = new(HandlePlayerEvent);
            playerEventBinding.Add(PlayerHpUp);
            EventBus<PlayerEvent>.Register(playerEventBinding);
        }

        private void OnDisable()
        {
            EventBus<TestEvent>.Deregister(testEventBinding);
            EventBus<PlayerEvent>.Deregister(playerEventBinding);
        }

        private void Awake()
        {
            
        }

        private void HandlePlayerEvent(PlayerEvent @event)
        {
            Debug.Log($"{@event.hp} & {@event.mana}");
        }

        private void PlayerHpUp(PlayerEvent playerEvent){
            playerEvent.hp += 100;
            Debug.Log(playerEvent.hp);
        }

        private void HandleTestEvent(TestEvent @event)
        {
            Debug.Log("ha");
        }

        void Start()
        {
            temp = new PlayerEvent
            {
                hp = 0,
                mana = 0
            };
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                EventBus<PlayerEvent>.Raise(temp);
            }
        }
    }

    public struct TestEvent : IEvent
    {

    }

    public struct PlayerEvent : IEvent
    {
        public int hp;
        public int mana;
    }
}
