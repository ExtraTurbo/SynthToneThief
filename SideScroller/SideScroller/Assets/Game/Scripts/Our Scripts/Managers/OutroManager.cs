using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutroManager : MonoBehaviour
{
    private static OutroManager instance;
    public static OutroManager Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private Button skipButton;
    [SerializeField]
    private float skipButtonActivateTime = 2.0f;

    [SerializeField]
    private Image screenImage;
    [SerializeField]
    private float screenFadeInSpeed = 0.5f;

    [SerializeField]
    private List<string> storyLines;
    [SerializeField]
    private Text textBox;
    [SerializeField]
    private float textFadeSpeed = 0.5f;
    [SerializeField]
    private float textLingerTime = 2.0f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        skipButton.interactable = false;
        screenImage.gameObject.SetActive(true);
        screenImage.CrossFadeAlpha(1.0f, 0.0f, true);
        textBox.CrossFadeAlpha(0.0f, 0.0f, true);
        StartCoroutine(FadeScreen());
        StartCoroutine(ActivateSkipButton());
    }

    public void SkipButton()
    {
        StopAllCoroutines();
        SceneManager.LoadScene("Credits");
    }

    private IEnumerator ActivateSkipButton()
    {
        yield return new WaitForSeconds(skipButtonActivateTime);
        skipButton.interactable = true;
    }

    private IEnumerator FadeScreen()
    {
        screenImage.CrossFadeAlpha(0.0f, screenFadeInSpeed, false);
        yield return new WaitForSeconds(screenFadeInSpeed);
        screenImage.gameObject.SetActive(false);
        yield return StartCoroutine(PlayStory());
        screenImage.gameObject.SetActive(true);
        screenImage.CrossFadeAlpha(0.0f, 0.0f, true);
        screenImage.CrossFadeAlpha(1.0f, screenFadeInSpeed, false);
        skipButton.interactable = false;
        yield return new WaitForSeconds(screenFadeInSpeed + 0.5f);
        SkipButton();
    }

    private IEnumerator PlayStory()
    {
        foreach (string line in storyLines)
        {
            textBox.text = line;
            textBox.CrossFadeAlpha(1.0f, textFadeSpeed, false);
            yield return new WaitForSeconds(textFadeSpeed);
            yield return new WaitForSeconds(textLingerTime);
            textBox.CrossFadeAlpha(0.0f, textFadeSpeed, false);
            yield return new WaitForSeconds(textFadeSpeed);
        }
        yield return new WaitForSeconds(0.5f);
    }
}
