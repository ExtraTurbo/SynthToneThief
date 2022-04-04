using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBox : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private MeshRenderer meshRenderer;
    [SerializeField]
    private BoxCollider boxCollider;
    [SerializeField]
    private GameObject child;

    private void Awake()
    {
        if (!TryGetComponent<AudioSource>(out AudioSource audioSource))
        {
            Debug.LogError("RedBox has no Audio Source!!");
        }
    }

    public void DestroyBox()
    {
        StartCoroutine(Death());
    }

    private IEnumerator Death()
    {
        if (meshRenderer != null)
        {
            meshRenderer.enabled = false;
        }
        if (boxCollider != null)
        {
            boxCollider.enabled = false;
        }
        if (child != null)
        {
            child.SetActive(false);
        }
        //audioSource.PlayOneShot("");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
