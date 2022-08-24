using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    private GameObject _player;
    private Vector3 _gap = new Vector3(4.5f, 9.5f, -10f);

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void LateUpdate()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        float xPositionCamera = _player.transform.position.x + _gap.x;
        float yPositionCamera = _gap.y;
        float zPositionCamera = _player.transform.position.z + _gap.z;
        transform.position = new Vector3 (xPositionCamera, yPositionCamera, zPositionCamera);
    }
}
