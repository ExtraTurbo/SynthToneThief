using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private MenuManager instance;
    public MenuManager Instance
    {
        get { return instance; }
    }


    [SerializeField]
    private GameObject pauseMenuGO;
    [SerializeField]
    private PlayerController playerController;

    private bool isPaused;
    private bool canPause;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        isPaused = false;
        canPause = true;
        pauseMenuGO.SetActive(false);
    }

    private void Update()
    {
        bool pause = Input.GetButtonDown("Cancel");

        // if player pressed ESC & not already paused & they can pause
        if(pause && !isPaused && canPause)
        {
            PauseGame();
        }
        else if (pause && isPaused)
        {
            UnpauseGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0.0f;
        isPaused = true;
        playerController.Paused = true;
        pauseMenuGO.SetActive(true);
    }

    private void UnpauseGame()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        playerController.Paused = false;
        pauseMenuGO.SetActive(false);
    }
}
