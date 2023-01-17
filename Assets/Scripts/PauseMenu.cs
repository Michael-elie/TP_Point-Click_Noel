using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private  Button PauseButton;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; 


    private void Start()
    {
        Time.timeScale = 1f;
        
    }

    public void  PauseGame()
    {
        
            if (GameIsPaused)
            {
                Play();
            }
            else
            {
                Stop();
            }

        
    }



    public  void Play()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Stop()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void MainMenuButton2()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    
}
