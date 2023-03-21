using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BR.Player;
using BR.UI;

namespace BR.GameCondition
{
    public class GameCondition: MonoBehaviour
    {   
        [SerializeField] private int _coinRequiredToComplete;

        private bool _isConditionTrue = false;

        void Update()
        {

            // checking if the required coin is equal to coin collected and bool is used to run this condition for once
            if(_coinRequiredToComplete == PlayerCoinHitChecker.coinCollected && !_isConditionTrue)
            {
                UIManager.UpdateGameWinDele?.Invoke();
                _isConditionTrue = true;
            }
        }
    }
}
