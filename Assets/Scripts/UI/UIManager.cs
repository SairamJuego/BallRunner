using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BR.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinScore;

        [SerializeField] private GameObject _gameOverMenu;

        [SerializeField] private GameObject _gameWinMenu;
        

        public void UpdateCoinScore(int coin)
        {
            _coinScore.text = "Coin Collected = " + coin;
        }

        public void ActivateGameover()
        {
            _gameOverMenu.SetActive(true);
        }

        public void ActivateGameWin()
        {
            _gameWinMenu.SetActive(true);
        }
        
    }
}
