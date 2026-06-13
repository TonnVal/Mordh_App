using System.Collections.Generic;
using UnityEngine;

namespace Components.UIBandPanel.Scripts
{
    public class UIBandPanelController : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _bandItems;
        [SerializeField] private GameObject _bandItemsPrefab;

        public void AddNewBand()
        {
            _bandItems.Add(Instantiate(_bandItemsPrefab, transform));
        }
    }
}
