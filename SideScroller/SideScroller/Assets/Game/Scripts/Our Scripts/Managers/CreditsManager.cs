using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{
    [SerializeField]
    private Image creditsScreen;
    [SerializeField]
    private Image playAgainScreen;
    [SerializeField]
    private Image background;

    [SerializeField]
    private Button playButton;
    [SerializeField]
    private Button quitButton;

    [SerializeField]
    private float fadeInTime = 1.0f;
    [SerializeField]
    private float creditsLingerTime = 10.0f;

    private void Start()
    {
        creditsScreen.gameObject.SetActive(true);
        playAgainScreen.gameObject.SetActive(false);
        background.gameObject.SetActive(true);

        playButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);

        StartCoroutine(ShowCredits());
    }

    private IEnumerator ShowCredits()
    {
        yield return new WaitForSeconds(1.0f);
        background.CrossFadeAlpha(0.0f, fadeInTime, false);
        yield return new WaitForSeconds(creditsLingerTime);
        background.CrossFadeAlpha(1.0f, fadeInTime, false);
        yield return new WaitForSeconds(fadeInTime);
        creditsScreen.gameObject.SetActive(false);
        playAgainScreen.gameObject.SetActive(true);
        background.CrossFadeAlpha(0.0f, 0.5f, false);
        yield return new WaitForSeconds(0.5f);
        background.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
