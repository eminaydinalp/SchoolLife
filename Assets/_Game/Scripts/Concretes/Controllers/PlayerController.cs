using System;
using _Game.Scripts.Abstacts.Movement;
using _Game.Scripts.Concretes.Movement;
using UnityEngine;
using UnityEngine.AI;

namespace _Game.Scripts.Concretes.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private IMover _moveWithNavmesh;
        
        [SerializeField] private Transform target;
        public Transform Target
        {
            get => target;
            set => target = value;
        }

        private void Awake()
        {
            _moveWithNavmesh = new MoveWithNavmesh(this);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _moveWithNavmesh.Move();
            }
        }
    }
}
