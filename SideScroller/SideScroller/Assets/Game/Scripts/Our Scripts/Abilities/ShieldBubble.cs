using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBubble : MonoBehaviour
{
    [SerializeField]
    private float lifeTime = 3.0f;

    void Start()
    {
        PlayerBody.ShieldAvailable = false;
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shieldable"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnDestroy()
    {
        PlayerBody.ShieldAvailable = true;
    }
}
