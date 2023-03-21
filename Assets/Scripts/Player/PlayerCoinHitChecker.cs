using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BR.UI;

namespace BR.Player
{
    public class PlayerCoinHitChecker : MonoBehaviour
    {
        
        //public variable to store the hit coin number
        public static int coinCollected;

        //private variable
        private AudioSource _coinSound;
        // Start is called before the first frame update
        void Start()
        {
             _coinSound = GetComponent<AudioSource>();
        }

//is checking if the player has hit the coin if yess then add coin and also play coin sound
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Coin"))
            {
                coinCollected++;
                UIManager.UpdateCoinDele?.Invoke();
                _coinSound.Play();
                other.gameObject.SetActive(false);
            }
        }
    }

}
