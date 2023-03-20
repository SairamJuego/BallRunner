using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BR.Player
{
    public class PlayerBehaviour : MonoBehaviour
    {
        #region Variables
        //static 
        public int coinCollected;

        //private variables
        Rigidbody rb;
        //Vector3 move = Vector3.zero;
        private bool _isGrounded = false;

        //private serializable variables
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _jumpSpeed;

        [SerializeField] private GameObject _particleOnDeath;

        

        #endregion

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log(coinCollected);
            if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            {
                rb.AddForce(Vector3.up * _jumpSpeed , ForceMode.Impulse);
                _isGrounded = false;
            }
        }

        void FixedUpdate()
        {
            //for moving
            rb.AddForce(Movement() * _moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }

        Vector3 Movement()
        {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }

        public void PlayerOnDeath()
        {
            this.gameObject.SetActive(false);
            Instantiate(_particleOnDeath,transform.position,Quaternion.identity);
        }


#region Collision and Trigger
        void OnCollisionStay(Collision collisionInfo)
        {
            _isGrounded = true;   
        }
        void OnCollisionExit(Collision collisionInfo)
        {
            _isGrounded = false;
        }

        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.CompareTag("Coin"))
            {
                coinCollected --;
                other.gameObject.SetActive(false);
            }
        }

        #endregion
        
    }
    

}
