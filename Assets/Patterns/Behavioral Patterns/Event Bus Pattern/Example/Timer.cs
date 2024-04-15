using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DesignPatterns.EventBusPattern.Example
{
    public class Timer : MonoBehaviour
    {
        public int playTime = 10;
        public TMP_Text timerText;

        private bool isReady = false;
        private WaitForSeconds oneSecond = new WaitForSeconds(1f);

        private void OnEnable()
        {
            EventBus.Register(GameState.Preparation, () => timerText.text = playTime.ToString());
            EventBus.Register(GameState.Begin, SetReady);
            EventBus.Register(GameState.End, GameEnd);
        }

        IEnumerator Start()
        {
            yield return new WaitUntil(IsStarted);
            var countdown = playTime;
            for (int i = countdown; i > 0; i--)
            {
                timerText.text = i.ToString();
                yield return oneSecond;
            }
            EventBus.Publish(GameState.End);
        }

        public void SetReady() => isReady = true;

        private bool IsStarted() => isReady;

        private void GameEnd()
        {
            timerText.text = "Game Finished";
            Destroy(gameObject);
        }
    }
}