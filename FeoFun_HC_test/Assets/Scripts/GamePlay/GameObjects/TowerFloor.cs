using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFloor : MonoBehaviour
{
    private EventManager _eventManager;

    private void Start()
    {
        _eventManager = GameObject.FindGameObjectWithTag("EventManager").GetComponent<EventManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Neutral")
            _eventManager.CrushToNeutralCube(other.gameObject);
        if (other.gameObject.tag == "Enemy")
            _eventManager.CrushToEnemyCube(other, gameObject);
        if (other.gameObject.tag == "Finish")
            _eventManager.ReachedFinishLine();
    }
}
