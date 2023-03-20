using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BR.Player
{
    public class PlayerMove : MonoBehaviour
    {
        #region Variables
        //private variables
        private Rigidbody _rigidbody;
        private bool _isGrounded = false;

        //private serializable variables
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _jumpSpeed;

        #endregion


        // Start is called before the first frame update
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            //for activating jump
            if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
            {
                _rigidbody.AddForce(Vector3.up * _jumpSpeed , ForceMode.Impulse);
                _isGrounded = false;
            }
        }

        void FixedUpdate()
        {
            //for moving
            _rigidbody.AddForce(Movement() * _moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }

        //gives direction for the force to move
        private Vector3 Movement()
        {
            return new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }

        #region Unity Events

        //to check if the player is grounded
        void OnCollisionStay(Collision collisionInfo)
        {
            _isGrounded = true;   
        }
        void OnCollisionExit(Collision collisionInfo)
        {
            _isGrounded = false;
        }

        #endregion
    }
    

}

