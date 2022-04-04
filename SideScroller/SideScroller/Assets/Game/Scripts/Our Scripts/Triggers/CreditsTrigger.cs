using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsTrigger : MonoBehaviour
{
    [SerializeField]
    private Image blackScreen;

    [SerializeField]
    private float fadeTime = 3.0f;

    private bool endingGame = false;

    private void Start()
    {
        endingGame = false;
        blackScreen.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !endingGame)
        {
            endingGame = true;
            StartCoroutine(FadeToBlack());
        }
    }

    private IEnumerator FadeToBlack()
    {
        blackScreen.gameObject.SetActive(true);
        blackScreen.CrossFadeAlpha(0.0f, 0.0f, true);
        blackScreen.CrossFadeAlpha(1.0f, fadeTime, false);
        yield return new WaitForSeconds(fadeTime + 0.5f);
        SceneManager.LoadScene("Outro");
    }
}
