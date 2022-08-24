using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float _speed = 300f;
    [SerializeField] private float _forceJump = 100f;
    private Rigidbody _playerRb;
    

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

    public void Jump()
    {
        Debug.Log("jump");
        _playerRb.AddForce(Vector3.up * _forceJump, ForceMode.Impulse);
    }
}
