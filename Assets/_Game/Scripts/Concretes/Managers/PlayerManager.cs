using System;
using _Game.Scripts.Concrates.Utilities;
using _Game.Scripts.Concretes.Controllers;
using UnityEngine;

namespace _Game.Scripts.Concretes.Managers
{
    public class PlayerManager : MonoBehaviour
    {
        public PlayerController[] playerControllers;

        public Transform[] targets;


        private void Start()
        {
            for (int i = 0; i < playerControllers.Length; i++)
            {
                playerControllers[i].Target = targets[i];
            }
        }
    }
}
