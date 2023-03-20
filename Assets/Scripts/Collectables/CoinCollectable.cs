using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BR.Collectables
{
    public class CoinCollectable : MonoBehaviour
    {
        [SerializeField] private float _rotateSpeed;

        
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(_rotateSpeed * Time.deltaTime, 0, 0));
        }  
    }
}
