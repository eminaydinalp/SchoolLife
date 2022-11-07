using System;
using _Game.Scripts.Concrates.Utilities;
using _Game.Scripts.Concretes.Managers;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game.Scripts.Concretes.Uis
{
    public class FailPanel : MonoBehaviour
    {
        public void TryAgainButton()
        {
            GameManager.Instance.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        public void SkipButton()
        { 
            GameManager.Instance.LoadScene(Consts.Step2);
        }
    }
}