using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatusManager : MonoBehaviour
{
    public bool RunningGame { get; private set; }
    private UIManager _uIManager;

    private void Start()
    {
        _uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();   
        PauseGame();
    }

    public void WinRound()
    {
        PauseGame();
        SceneManager.LoadScene(0);
    }

    public void LossRound()
    {
        PauseGame();
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        RunningGame = false;
        _uIManager.SetActiveTabToStartText(false);
    }

    public void StartGame() 
    {
        Time.timeScale = 1f;
        RunningGame = true;
        _uIManager.SetActiveTabToStartText(true);
    }
}
