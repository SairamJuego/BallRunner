using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using BR.Player;
using UnityEngine.UI;
using BR.SceneControll;

namespace BR.UI
{
    public class UIManager : MonoBehaviour
    {   //creating a delegate to update the coin ui when required
        public delegate void UpdateUIDelegate();
        public static UpdateUIDelegate UpdateCoinDele;

        public static UpdateUIDelegate UpdateGameOverDele;
        public static UpdateUIDelegate UpdateGameWinDele;

        //private serializable variables
        [SerializeField] private TextMeshProUGUI _coinScore;

        [SerializeField] private GameObject _gameOverMenu;

        [SerializeField] private GameObject _gameWinMenu;
        void OnEnable()
        {
            //subscribing the delegate
            UpdateCoinDele += UpdateCoinScore;
            UpdateGameOverDele += ActivateGameover;
            UpdateGameWinDele += ActivateGameWin;
        }

        void OnDisable()
        {
            //unsubscribing the delegate
            UpdateCoinDele -= UpdateCoinScore;
            UpdateGameOverDele -= ActivateGameover;
            UpdateGameWinDele -= ActivateGameWin;
        }

        //Used to Update the Coin UI
        public void UpdateCoinScore()
        {
            _coinScore.text = "Coin collected = " + PlayerCoinHitChecker.coinCollected.ToString();
        }

        //to make gameover ui active
        public void ActivateGameover()
        {
            _gameOverMenu.SetActive(true);
            
        }

        //to make gamewin ui active
        public void ActivateGameWin()
        {
            _gameWinMenu.SetActive(true);
        }

        void Start()
        {
            UpdateCoinDele?.Invoke();
        }
        
    }
}
