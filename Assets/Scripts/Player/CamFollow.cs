using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BR.Player
{
    public class CamFollow : MonoBehaviour
    {
        [SerializeField] private Transform _playerTransform;

        private Vector3 _camOffset;
        // Start is called before the first frame update
        void Start()
        {
            _camOffset = this.transform.position - _playerTransform.position;
        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = _playerTransform.position + _camOffset;
        }
    }
}
