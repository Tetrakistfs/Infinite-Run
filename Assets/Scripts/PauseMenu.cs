using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject loseMenuUI;

    [SerializeField] private AudioSource bgmMusic;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        loseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        bgmMusic.UnPause();
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        loseMenuUI.SetActive(false);
        Time.timeScale = 0f;
        bgmMusic.Pause();
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Lose()
    {
        bgmMusic.Stop();
        loseMenuUI.SetActive(true);
    }
}

