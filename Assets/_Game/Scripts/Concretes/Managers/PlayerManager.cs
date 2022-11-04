using System;
using _Game.Scripts.Concrates.Utilities;
using _Game.Scripts.Concretes.Controllers;
using UnityEngine;
using UnityEngine.AI;

namespace _Game.Scripts.Concretes.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        public PlayerController[] playerControllers;

        public Transform[] targets;

        public Transform firstPoint;

        public int index;


        private void Start()
        {
            for (int i = 0; i < playerControllers.Length; i++)
            {
                playerControllers[i].Target = firstPoint;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.Target = targets[index];
                playerController.Move();
                
                index++;

                if (index == targets.Length)
                {
                    index = 0;
                }
            }
        }
    }
}
