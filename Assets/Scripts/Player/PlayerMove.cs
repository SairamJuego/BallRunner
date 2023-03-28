using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


namespace BR.Player
{
    public class PlayerMove : MonoBehaviour
    {
        #region Variables
        //private variables
        private Rigidbody _rigidbody;
        private bool _isGrounded = false;

        private Vector2 _move;

        //private serializable variables
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _jumpSpeed;

        //input system variable
        private Playerinput _playerInput;

        #endregion

        void Awake()
        {
            _playerInput = new Playerinput();
        }
        void OnEnable()
        {
            
            _playerInput.Enable();
            _playerInput.OnFoot.Jump.performed += ctx => Jump();
            
        }
        
        void OnDisable()
        {
            _playerInput.Disable();
            _playerInput.OnFoot.Jump.performed -= ctx => Jump();
        }

        // Start is called before the first frame update
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        void FixedUpdate()
        {
            //for moving
            _rigidbody.AddForce(Movement() * _moveSpeed * Time.deltaTime, ForceMode.Impulse);
        }

        //gives direction for the force to move
        private Vector3 Movement()
        {
            _move = new Vector2(_playerInput.OnFoot.Movement.ReadValue<Vector2>().x,_playerInput.OnFoot.Movement.ReadValue<Vector2>().y);
            return new Vector3(_move.x, 0, _move.y);
        }

        //for activating jump
        private void Jump()
        {
            if (_isGrounded)
            {
                _rigidbody.AddForce(Vector3.up * _jumpSpeed , ForceMode.Impulse);
                _isGrounded = false;
            }
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

