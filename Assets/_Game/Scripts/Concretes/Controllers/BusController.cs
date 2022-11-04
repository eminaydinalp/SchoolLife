using System;
using System.Collections;
using System.Collections.Generic;
using _Game.Scripts.Concretes.Managers;
using _Game.Scripts.Concretes.Uis;
using UnityEngine;

namespace _Game.Scripts.Concretes.Controllers
{
    public class BusController : MonoBehaviour
    {
        [SerializeField] private BusFillSlider busFillSlider;
        public int capacity;
        public int currentPassengerCount;

        private void OnTriggerEnter(Collider other)
        {
            
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                currentPassengerCount++;
                if (currentPassengerCount > capacity)
                {
                    StartCoroutine(GameOver());
                }
                busFillSlider.IncreaseSliderValue();
            }
        }

        private void Update()
        {
            if(GameManager.Instance.isFinish) return;
            if (Input.GetMouseButtonDown(0) && currentPassengerCount > 0)
            {
                Validation();
            }
        }

        private void Validation()
        {
            GameManager.Instance.isFinish = true;
            
            if (capacity * 0.7f > currentPassengerCount || currentPassengerCount > capacity)
            {
                GameManager.Instance.OnFail?.Invoke();
            }
            else
            {
                GameManager.Instance.OnWin?.Invoke();

            }
        }

        IEnumerator GameOver()
        {
            yield return new WaitForSeconds(1f);
            if (GameManager.Instance.isFinish) yield break;
            GameManager.Instance.OnFail?.Invoke();
            
            GameManager.Instance.isFinish = true;
        }
    }
}
