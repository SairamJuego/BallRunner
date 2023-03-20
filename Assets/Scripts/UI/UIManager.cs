using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using BR.Player;

namespace BR.UI
{
    public class UIManager : MonoBehaviour
    {
        public delegate void UpdateCoinDelegate();

        public static UpdateCoinDelegate UpdateCoinDele ; 
        [SerializeField] private TextMeshProUGUI _coinScore;

        [SerializeField] private GameObject _gameOverMenu;

        [SerializeField] private GameObject _gameWinMenu;

        

        void OnEnable()
        {
            UpdateCoinDele += UpdateCoinScore;
        }

        void OnDisable() {
            UpdateCoinDele -= UpdateCoinScore;
        }
        

        public void  UpdateCoinScore()
        {
            _coinScore.text = "Coin collected = " + PlayerCoinHitChecker.coinCollected.ToString();
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
