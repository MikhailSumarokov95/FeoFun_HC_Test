using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControler : MonoBehaviour
{
    private PlayerControler _playerControler;
    private void Start()
    {
        _playerControler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)) _playerControler.Jump();
    }
}
