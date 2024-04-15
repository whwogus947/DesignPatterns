using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.EventBusPattern.Example
{
    public class ClickController : MonoBehaviour
    {

        private bool isPlaying = false;
        private Ray ray;
        private RaycastHit hitInfo;

        private void OnEnable()
        {
            EventBus.Register(GameState.Begin, SetClickable);
            EventBus.Register(GameState.End, SetInclickable);
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0) && isPlaying)
            {
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hitInfo))
                {
                    OpenTheBox(hitInfo.collider.gameObject);
                }
            }
        }

        private void SetClickable() => isPlaying = true;
        private void SetInclickable() => isPlaying = false;

        private void OpenTheBox(GameObject target)
        {
            if (target.TryGetComponent(out SecretBox box))
            {
                box.Open();
            }
        }
    }
}
