using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidBody;
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "tape")
        {
            _rigidBody.AddForce(Vector3.forward * _speed);
        }
    }
}
