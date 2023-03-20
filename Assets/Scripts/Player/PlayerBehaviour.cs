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
    Vector3 move = Vector3.zero;

    //private serializable variables
    [SerializeField] private float moveSpeed;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        rb.AddForce(Movement()*moveSpeed*Time.deltaTime,ForceMode.Impulse);
    }

    Vector3 Movement()
    {
        return move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }
}

}
