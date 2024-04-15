using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace DesignPatterns.EventBusPattern.Example
{
    public class GameManager : MonoBehaviour
    {
        public Button gameStartButton;
        public TMP_Text scoreText;
        public SecretBox[] boxes;
        public GameObject mine;

        private int score = 0;

        private void OnEnable()
        {
            EventBus.Register(GameState.Preparation, SetRandomMineAndPrepare);
            EventBus.Register(GameState.Begin, RevealBoxes);
            EventBus.Register(GameState.Playing, SelectOnCorrectBox);
        }

        private void Start()
        {
            gameStartButton.onClick.AddListener(() => EventBus.Publish(GameState.Begin));
            EventBus.Publish(GameState.Preparation);
        }

        private void SetRandomMineAndPrepare()
        {
            var randomNumber = Random.Range(0, boxes.Length);
            boxes[randomNumber].SetBoxAsMine(mine);
            Array.ForEach(boxes, (box) => box.gameObject.SetActive(false));
        }

        private void RevealBoxes()
        {
            gameStartButton.gameObject.SetActive(false);
            Array.ForEach(boxes, (box) => box.gameObject.SetActive(true));
        }

        private void SelectOnCorrectBox()
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
