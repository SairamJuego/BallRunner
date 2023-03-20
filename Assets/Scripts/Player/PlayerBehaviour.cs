using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BR.Player
{
    public class PlayerBehaviour : MonoBehaviour
    {
        #region Variables
        //private variables
        Rigidbody rb;
        //Vector3 move = Vector3.zero;
        private bool _isGrounded = false;

        //private serializable variables
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _jumpSpeed;

        

        #endregion

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
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

        void OnCollisionEnter(Collision collisionInfo)
        {
            _isGrounded = true;   
        }
        void OnCollisionExit(Collision collisionInfo)
        {
            _isGrounded = false;
        }

        
        
    }

}
