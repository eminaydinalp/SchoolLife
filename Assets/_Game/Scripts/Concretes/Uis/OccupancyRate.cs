using _Game.Scripts.Concretes.Controllers;
using TMPro;
using UnityEngine;

namespace _Game.Scripts.Concretes.Uis
{
    public class OccupancyRate : MonoBehaviour
    {
        [SerializeField] private BusController busController;
        [SerializeField] private TMP_Text occupancyText;
        
        public void DisplayOccupancyRate()
        {
            occupancyText.text = "Occupancy Rate : " + busController.currentPassengerCount + "/" + busController.capacity;
        }
    }
}
