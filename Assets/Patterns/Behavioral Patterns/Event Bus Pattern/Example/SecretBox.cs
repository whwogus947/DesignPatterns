using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.EventBusPattern.Example
{
    public class SecretBox : MonoBehaviour
    {
        public bool IsMine => _isMine;

        private bool _isMine = false;
        private GameObject mine = null;

        public void SetBoxAsMine(GameObject minePrefab)
        {
            _isMine = true;
            mine = minePrefab;
        }

        public void Open()
        {
            if (IsMine)
            {
                Instantiate(mine, transform.position, Quaternion.identity);
                EventBus.Publish(GameState.End);
            }
            else
            {
                EventBus.Publish(GameState.Playing);
            }

            Destroy(gameObject);
        }
    }
}
