using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BR.SceneController
{
    public class SceneController : MonoBehaviour
    {
        // private variable used to store temp build index
        private int _sceneTempIndex;
        private void Start()
        {
            _sceneTempIndex = SceneManager.GetActiveScene().buildIndex;
        }

        public void NextLevel()
        {
            SceneManager.LoadScene(_sceneTempIndex + 1);
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(_sceneTempIndex);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
