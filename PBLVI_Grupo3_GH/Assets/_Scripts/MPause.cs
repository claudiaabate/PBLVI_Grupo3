using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MPause : SceneLoader
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                audioData.Play(0);
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public virtual void MenuButton()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        LoadMainMenu();
    }
}