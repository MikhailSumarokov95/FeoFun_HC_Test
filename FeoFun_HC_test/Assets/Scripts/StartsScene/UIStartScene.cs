using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIStartScene : MonoBehaviour
{
    [SerializeField] private Button _tabToPlay;

    private void Start()
    {
        _tabToPlay.onClick.AddListener(StartGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
