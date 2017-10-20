using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseBtn, pauseMenu;

    public void OnPause()
    {
        pauseMenu.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0;
    }

    public void OffPause()
    {
        pauseMenu.SetActive(false);
        pauseBtn.SetActive(true);
        Time.timeScale = 1;
    }

    public void MainMenu(string backtomenu)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(backtomenu);
    }

    public void ExitGamebtn()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
}
