using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;

    public GameObject gameOverMenu;

    public GameObject player;

    public GameObject tutorial;

    public bool isPaused;

    public bool isGameOver;

    public FoodTracker _foodTracker;

    private void Start()
    {
        _foodTracker = GameObject.Find("Player").GetComponent<FoodTracker>();

        tutorial.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame(!isPaused);
        }

        if (_foodTracker.foodMeter <= 0)
        {
            isGameOver = true;
            gameOverMenu.SetActive(true);
            Destroy(player);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            tutorial.SetActive(false);
        }

    }
    public void PauseGame(bool doPause)
    {
        isPaused = doPause;
        pauseMenu.SetActive(isPaused);

        if (isPaused)
        {
            Time.timeScale = 0;
        }

        else
        {
            Time.timeScale = 1;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGameAfterIntro()
    {
        SceneManager.LoadScene(2);
    }
   

}
