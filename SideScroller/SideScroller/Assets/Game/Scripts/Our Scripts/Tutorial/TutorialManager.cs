using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    private static TutorialManager instance;
    public static TutorialManager Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private Image tutorialPopup;
    [SerializeField]
    private Text tutorialText;

    private bool displaying;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        displaying = false;
    }

    private void Start()
    {
        tutorialText.text = "";
        tutorialText.gameObject.SetActive(false);
        tutorialPopup.gameObject.SetActive(false);
    }

    public IEnumerator ShowTutorial(string text, float time)
    {
        while (displaying)
        {
            yield return new WaitForSeconds(0.1f);
        }

        displaying = true;
        tutorialPopup.gameObject.SetActive(true);
        tutorialText.text = text;
        tutorialText.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        tutorialPopup.gameObject.SetActive(false);
        tutorialText.gameObject.SetActive(false);
        tutorialText.text = "";
        displaying = false;
    }
}
