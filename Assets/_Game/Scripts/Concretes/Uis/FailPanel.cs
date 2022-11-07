using System;
using _Game.Scripts.Concrates.Utilities;
using _Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace _Game.Scripts.Concretes.Uis
{
    public class FailPanel : MonoBehaviour
    {
        public void TryAgainButton()
        {
            GameManager.Instance.LoadScene(Consts.Step1);
        }
        
        public void SkipButton()
        { 
            GameManager.Instance.LoadScene(Consts.Step2);
        }
    }
}