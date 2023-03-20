using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BR.Player
{
    public class PlayerDeath : MonoBehaviour
    {
        //private variables
        [SerializeField] private GameObject _particleOnDeath;

        public static bool isPlayerDead{get;private set;}


        void Update()
        {
            if(transform.position.y < -15f && this.gameObject.activeInHierarchy)
            {
                PlayerOnDeath();  
            }
        }

        public void PlayerOnDeath()
        {
            isPlayerDead = true;
            this.gameObject.SetActive(false);
            Instantiate(_particleOnDeath, transform.position, Quaternion.identity);
        }
    }
}
