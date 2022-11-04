using _Game.Scripts.Abstacts.Movement;
using _Game.Scripts.Concretes.Controllers;
using _Game.Scripts.Concretes.Managers;
using UnityEngine;
using UnityEngine.AI;

namespace _Game.Scripts.Concretes.Movement
{
    public class MoveWithNavmesh : IMover
    {
        private PlayerController _playerController;
        private NavMeshAgent _navMeshAgent;
        
        public MoveWithNavmesh(PlayerController playerController)
        {
            _playerController = playerController;
            _navMeshAgent = _playerController.GetComponentInChildren<NavMeshAgent>();

            GameManager.Instance.OnFail += StopNavmesh;
            GameManager.Instance.OnWin += StopNavmesh;
        }

        public void Move()
        {
            _navMeshAgent.destination = _playerController.Target.position;
        }

        private void StopNavmesh()
        {
            _navMeshAgent.speed = 0;
            
            GameManager.Instance.OnFail -= StopNavmesh;
            GameManager.Instance.OnWin -= StopNavmesh;
        }
    }
}
