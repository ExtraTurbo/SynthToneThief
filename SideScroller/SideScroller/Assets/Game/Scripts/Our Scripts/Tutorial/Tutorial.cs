using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField]
    private string tutorialText;
    [SerializeField]
    private float displayTime = 5.0f;

    private bool displayed;

    private void Start()
    {
        displayed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !displayed)
        {
            displayed = true;
            StartCoroutine(TutorialManager.Instance.ShowTutorial(tutorialText, displayTime));
        }
    }
}
