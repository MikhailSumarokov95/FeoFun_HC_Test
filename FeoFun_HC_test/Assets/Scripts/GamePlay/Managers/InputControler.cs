using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControler : MonoBehaviour
{
    private float _forceJump;
    private PlayerControler _playerControler;
    private GameStatusManager _gameStatusManager;
    private bool _OnCoroutineUpForceJump;
    
    private void Start()
    {
        _playerControler = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();
        _gameStatusManager = GameObject.FindGameObjectWithTag("GameStatusManager").GetComponent<GameStatusManager>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) OnTabScreen();
    }

    private void OnTabScreen()
    {
        if (!_gameStatusManager.RunningGame) _gameStatusManager.StartGame();
        else if (!_OnCoroutineUpForceJump) StartCoroutine(Jump());
    }

    private IEnumerator Jump()
    {
        _OnCoroutineUpForceJump = true;
        while (true)
        {
            yield return null;
            if (_forceJump < 1) _forceJump += 0.02f;
            if (Input.GetMouseButtonUp(0)) break;
        }
        _playerControler.Jump(_forceJump);
        _forceJump = 0;
        _OnCoroutineUpForceJump = false;
    }
}
