using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BR.SceneControll
{
    public class SceneController : MonoBehaviour
    {
        // //creating a delegate to controll the scene
        // public delegate void SceneControllDelegate();

        // public static SceneControllDelegate SceneRestartDele;
        // public static SceneControllDelegate SceneNextLevelDele;
        // public static SceneControllDelegate SceneExitDele;

        // private variable used to store temp build index
        private int _sceneTempIndex;

        // void OnEnable()
        // {
        //     //subscribing the delegate
        //     SceneRestartDele += RestartScene;
        //     SceneNextLevelDele += NextLevel;
        //     SceneExitDele += ExitGame;
        // }

        // void OnDisable()
        // {
        //     //unsubscribing the delegate
        //     SceneRestartDele -= RestartScene;
        //     SceneNextLevelDele -= NextLevel;
        //     SceneExitDele -= ExitGame;
        // }
        private void Start()
        {
            //storing the current scene build index
            _sceneTempIndex = SceneManager.GetActiveScene().buildIndex;
        }

        //to advance to next level
        public void NextLevel()
        {
            SceneManager.LoadScene(_sceneTempIndex + 1);
        }

        //restart the current scene
        public void RestartScene()
        {
            SceneManager.LoadScene(_sceneTempIndex);
        }

        //quit the game completely
        public void ExitGame()
        {
            Application.Quit();
        }
    }
}
