using System;
using _Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace _Game.Scripts.Concretes.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private GameObject failPanel;
        [SerializeField] private GameObject winPanel;
        [SerializeField] private GameObject startPanel;
        [SerializeField] private GameObject fillSlider;
        [SerializeField] private OccupancyRate occupancyText;

        private void OnEnable()
        {
            GameManager.Instance.OnFail += OpenFailPanel;
            GameManager.Instance.OnWin += OpenWinPanel;
            GameManager.Instance.OnFail += OpenOccupancyRateText;
            GameManager.Instance.OnWin += OpenOccupancyRateText;
            GameManager.Instance.OnFail += CloseFillSlider;
            GameManager.Instance.OnWin += CloseFillSlider;
            GameManager.Instance.OnStartGame += CloseStartPanel;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnFail -= OpenFailPanel;
            GameManager.Instance.OnWin -= OpenWinPanel;
            GameManager.Instance.OnFail -= OpenOccupancyRateText;
            GameManager.Instance.OnWin -= OpenOccupancyRateText;
            GameManager.Instance.OnFail -= CloseFillSlider;
            GameManager.Instance.OnWin -= CloseFillSlider;
            GameManager.Instance.OnStartGame -= CloseStartPanel;
        }


        private void OpenFailPanel()
        {
            failPanel.SetActive(true);
        }
        private void OpenWinPanel()
        {
            winPanel.SetActive(true);
        }

        private void OpenOccupancyRateText()
        {
            occupancyText.gameObject.SetActive(transform);
            occupancyText.DisplayOccupancyRate();
        }

        private void CloseFillSlider()
        {
            fillSlider.SetActive(false);
        }

        private void CloseStartPanel()
        {
            startPanel.SetActive(false);
        }
    }
}
