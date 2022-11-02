using System;
using _Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace _Game.Scripts.Concretes.Controllers
{
    public class BusController : MonoBehaviour
    {
        public int capacity;
        public int currentPassengerCount;

        public int startCount;
        private void OnTriggerEnter(Collider other)
        {
            
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                currentPassengerCount++;
            }
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && startCount > 0)
            {
                Validation();
            }
            if (Input.GetMouseButtonUp(0))
            {
                startCount++;
            }
        }

        private void Validation()
        {
            if (capacity * 0.7f > currentPassengerCount || currentPassengerCount > capacity)
            {
                Debug.Log("Fail");
            }
            else
            {
                Debug.Log("Win");
            }
        }
    }
}
