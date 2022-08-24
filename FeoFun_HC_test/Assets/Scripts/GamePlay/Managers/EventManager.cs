using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private GameObject _towerFloor;
    [SerializeField] private GameObject _neutralCube;
    [SerializeField] private Material _neutral;
    private GameObject _player;
    private BoxCollider _playerBc;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerBc = _player.GetComponent<BoxCollider>();
    }

    public void CrushToNeutralCube(GameObject neutral)
    {
        Destroy(neutral);
        _player.transform.Translate(Vector3.up);
        _playerBc.size += Vector3.up * 2;
        Vector3 positionSpawnFloor = new Vector3(_player.transform.position.x, 0.5f, _player.transform.position.z);
        GameObject newTowerFloor = Instantiate(_towerFloor, positionSpawnFloor, _towerFloor.transform.rotation);
        newTowerFloor.transform.SetParent(_player.transform);
    }

    public void CrushToEnemyCube (Collider other, GameObject towerFloor)
    {
        other.isTrigger = false;
        towerFloor.transform.parent = null;
        _playerBc.size -= Vector3.up * 2;
        towerFloor.GetComponent<MeshRenderer>().material = _neutral;
    }
}
