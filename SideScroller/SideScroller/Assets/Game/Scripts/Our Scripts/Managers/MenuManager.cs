using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    private static MenuManager instance;
    public static MenuManager Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private GameObject pauseMenuGO;
    [SerializeField]
    private PlayerController playerController;

    private bool isPaused;
    private bool canPause;

    private bool guitarLocked;
    private bool drumsLocked;
    private bool fluteLocked;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        isPaused = false;
        canPause = true;

        guitarLocked = true;
        drumsLocked = true;
        fluteLocked = true;

        pauseMenuGO.SetActive(false);
    }

    private void Update()
    {
        bool pause = Input.GetButtonDown("Cancel");

        if (guitarLocked && WorldStatus.Instance.Phase >= 1)
        {
            guitarLocked = false;
            PauseMenuManager.Instance.UnlockGuitarControls();
        }
        if (drumsLocked && WorldStatus.Instance.Phase >= 2)
        {
            drumsLocked = false;
            PauseMenuManager.Instance.UnlockDrumsControls();
        }
        if (fluteLocked && WorldStatus.Instance.Phase >= 3)
        {
            fluteLocked = false;
            PauseMenuManager.Instance.UnlockFluteControls();
        }

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

    public void UnpauseGame()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
        playerController.Paused = false;
        pauseMenuGO.SetActive(false);
    }
}
