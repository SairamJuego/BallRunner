using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BR.Collectables
{
    public class CoinCollectable : MonoBehaviour
    {
        [SerializeField] private float _rotateSpeed;
        // Start is called before the first frame update
        
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(_rotateSpeed * Time.deltaTime, 0, 0));
        }
    }
}
