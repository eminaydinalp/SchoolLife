using _Game.Scripts.Concretes.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace _Game.Scripts.Concretes.Uis
{
    public class BusFillSlider : MonoBehaviour
    {
        [SerializeField] private Slider fillSlider;
        [SerializeField] private BusController busController;

        private void Start()
        {
            SetSliderMaxValue();
        }

        public void IncreaseSliderValue()
        {
            fillSlider.value = busController.currentPassengerCount;
        }

        private void SetSliderMaxValue()
        {
            fillSlider.maxValue = busController.capacity;
        }
    }
}
