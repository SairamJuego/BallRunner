using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BR.UI;


namespace BR.Player
{
    public class PlayerDeath : MonoBehaviour
    {
        //private variables
        [SerializeField] private GameObject _particleOnDeath;

        void Update()
        {
            //to check if the player has fallen down if yes then call death function
            if(transform.position.y < -15f && this.gameObject.activeInHierarchy)
            {
                PlayerOnDeath();  
            }
        }

        public void PlayerOnDeath()
        {
            this.gameObject.SetActive(false);
            Instantiate(_particleOnDeath, transform.position, Quaternion.identity);
            UIManager.UpdateGameOverDele?.Invoke();
        }
    }
}
