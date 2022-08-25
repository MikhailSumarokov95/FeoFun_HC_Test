using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float _speed = 300f;
    [SerializeField] private float _jumpForce = 10f;
    private Rigidbody _playerRb;
    private bool _onStayRoad;
    

    private void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }

    public void Jump(float forceJump)
    {
        if (_onStayRoad) _playerRb.AddForce(Vector3.up * forceJump * _jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Road") _onStayRoad = true;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Road") _onStayRoad = false;
    }
}
