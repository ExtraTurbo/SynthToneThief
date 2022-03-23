using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject logoSplashGO;
    [SerializeField]
    private Image splashImage;
    [SerializeField]
    private float splashFadeTime = 2.0f;
    [SerializeField]
    private float splashLingerTime = 2.0f;

    [SerializeField]
    private GameObject mainMenuGO;
    [SerializeField]
    private Image mainMenuBG;
    [SerializeField]
    private Image mainMenuImage;
    [SerializeField]
    private float menuFadeTime = 2.0f;

    [SerializeField]
    private Button startButton;
    [SerializeField]
    private Button quitButton;

    private void Start()
    {
        splashImage.CrossFadeAlpha(0.0f, 0.0f, true);
        mainMenuBG.CrossFadeAlpha(0.0f, 0.0f, true);
        mainMenuImage.CrossFadeAlpha(0.0f, 0.0f, true);

        StartCoroutine(SplashScreen());
    }

    public void StartButton()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }

    private IEnumerator SplashScreen()
    {
        splashImage.CrossFadeAlpha(1.0f, splashFadeTime, false);
        yield return new WaitForSeconds(splashFadeTime);
        yield return new WaitForSeconds(splashLingerTime);
        splashImage.CrossFadeAlpha(0.0f, splashFadeTime, false);
        yield return new WaitForSeconds(splashFadeTime);
        yield return new WaitForSeconds(0.5f);
        yield return StartCoroutine(MainMenu());
        logoSplashGO.SetActive(false);
    }

    private IEnumerator MainMenu()
    {
        mainMenuBG.CrossFadeAlpha(1.0f, menuFadeTime, false);
        yield return new WaitForSeconds(menuFadeTime);
        mainMenuImage.CrossFadeAlpha(1.0f, menuFadeTime, false);
        yield return new WaitForSeconds(menuFadeTime);
        startButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }
}
