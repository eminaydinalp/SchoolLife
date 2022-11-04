using System;
using _Game.Scripts.Concretes.Managers;
using UnityEngine;

namespace _Game.Scripts.Concretes.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] private GameObject failPanel;
        [SerializeField] private GameObject winPanel;
        [SerializeField] private GameObject fillSlider;
        [SerializeField] private OccupancyRate occupancyText;

        private void OnEnable()
        {
            GameManager.Instance.OnFail += OpenFailPanel;
            GameManager.Instance.OnWin += OpenWinPanel;
            GameManager.Instance.OnFail += OpenOccupancyRateText;
            GameManager.Instance.OnWin += OpenOccupancyRateText;
            GameManager.Instance.OnFail += ClosoFillSlider;
            GameManager.Instance.OnWin += ClosoFillSlider;
        }

        private void OnDisable()
        {
            GameManager.Instance.OnFail -= OpenFailPanel;
            GameManager.Instance.OnWin -= OpenWinPanel;
            GameManager.Instance.OnFail -= OpenOccupancyRateText;
            GameManager.Instance.OnWin -= OpenOccupancyRateText;
            GameManager.Instance.OnFail -= ClosoFillSlider;
            GameManager.Instance.OnWin -= ClosoFillSlider;
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

        private void ClosoFillSlider()
        {
            fillSlider.SetActive(false);
        }
    }
}
