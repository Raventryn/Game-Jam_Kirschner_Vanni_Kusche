using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Credits()
    {
        SceneManager.LoadScene(3);
    }

    public void CreditExit()
    {
        SceneManager.LoadScene(0);
    }
}
