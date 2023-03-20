using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BR.Player;
using BR.UI;

namespace BR.GameManager
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PlayerBehaviour _player;

        [SerializeField] private UIManager _uIManager;

        [SerializeField] private int _coinsToCollect;
        // Start is called before the first frame update
        void Start()
        {
            _player.coinCollected = _coinsToCollect; 
            _uIManager.UpdateCoinScore(_player.coinCollected);
        }

        // Update is called once per frame
        void Update()
        {
            if(_player.transform.position.y < -15f && _player.gameObject.activeInHierarchy)
            {
                _player.PlayerOnDeath();
                _uIManager.ActivateGameover();
            }

            if(_player.coinCollected == 0)
            {
                _uIManager.ActivateGameWin();
            }

            _uIManager.UpdateCoinScore(_player.coinCollected);
        }

        public void NextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
