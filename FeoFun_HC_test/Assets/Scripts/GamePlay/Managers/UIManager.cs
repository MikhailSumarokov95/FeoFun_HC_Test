using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _tabToStartText;

    public void SetActiveTabToStartText(bool status)
    {
        _tabToStartText.enabled = !status;
    }
}
