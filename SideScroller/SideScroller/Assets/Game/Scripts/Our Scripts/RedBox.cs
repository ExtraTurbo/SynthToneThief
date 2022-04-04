using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBox : MonoBehaviour
{
    private AudioSource audioSource;
    private MeshRenderer r;
    private BoxCollider c;
    private GameObject child;

    private void Awake()
    {
        gameObject.TryGetComponent<AudioSource>(out audioSource);
        gameObject.TryGetComponent<MeshRenderer>(out r);
        gameObject.TryGetComponent<BoxCollider>(out c);

        if (transform.childCount > 0)
        {
            child = gameObject.transform.GetChild(0).gameObject;
        }
        else
        {
            child = null;
        }
    }

    public void DestroyBox()
    {
        Debug.Log("Calling DestroyBox");
        StartCoroutine(Death());
    }

    private IEnumerator Death()
    {
        if (r != null)
        {
            r.enabled = false;
        }
        if (c != null)
        {
            c.enabled = false;
        }
        if (child != null)
        {
            child.SetActive(false);
        }
        if (audioSource != null)
        {
            audioSource.PlayOneShot(audioSource.clip, 2.0f);
        }
        else
        {
            Debug.LogError("Null Audio Source on RedBox");
        }    
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }
}
