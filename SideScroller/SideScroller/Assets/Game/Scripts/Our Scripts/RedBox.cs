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
            //audioSource.PlayOneShot("");
        }
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
