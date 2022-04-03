using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    private static PauseMenuManager instance;
    public static PauseMenuManager Instance
    {
        get { return instance; }
    }


    [SerializeField]
    private GameObject pauseScreen;
    [SerializeField]
    private GameObject controlsScreen;

    [SerializeField]
    private Button continueButton;
    [SerializeField]
    private Button controlsButton;
    [SerializeField]
    private Button quitButton;

    // Controls Screen //
    [SerializeField]
    private GameObject guitarLocked;
    [SerializeField]
    private GameObject drumsLocked;
    [SerializeField]
    private GameObject fluteLocked;

    [SerializeField]
    private GameObject guitarControls;
    [SerializeField]
    private GameObject drumsControls;
    [SerializeField]
    private GameObject fluteControls;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        controlsScreen.SetActive(false);
        pauseScreen.SetActive(true);

        guitarLocked.SetActive(true);
        drumsLocked.SetActive(true);
        fluteLocked.SetActive(true);

        guitarControls.SetActive(false);
        drumsControls.SetActive(false);
        fluteControls.SetActive(false);
    }

    // Pause Menu //

    public void ContinueButton()
    {
        MenuManager.Instance.UnpauseGame();
    }

    public void ControlsButton()
    {
        pauseScreen.SetActive(false);
        controlsScreen.SetActive(true);
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }

    // Control Screen //

    public void ReturnButton()
    {
        pauseScreen.SetActive(true);
        controlsScreen.SetActive(false);
    }

    public void UnlockGuitarControls()
    {
        guitarLocked.SetActive(false);
        guitarControls.SetActive(true);
    }

    public void UnlockDrumsControls()
    {
        drumsLocked.SetActive(false);
        drumsControls.SetActive(true);
    }

    public void UnlockFluteControls()
    {
        fluteLocked.SetActive(false);
        fluteControls.SetActive(true);
    }
}
