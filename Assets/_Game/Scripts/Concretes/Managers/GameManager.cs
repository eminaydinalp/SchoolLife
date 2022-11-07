using System;
using System.Collections;
using _Game.Scripts.Concrates.Utilities;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Game.Scripts.Concretes.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public Action OnWin;
        public Action OnFail;
        public Action OnStartGame;
        public bool isFinish;
        
        public void LoadScene(string sceneManager)
        {
            isFinish = false;
            StartCoroutine(LoadSceneAsync(sceneManager));
        }

        private IEnumerator LoadSceneAsync(string sceneName)
        {
            Time.timeScale = 1;
            yield return SceneManager.LoadSceneAsync(sceneName);
        }
    }
}