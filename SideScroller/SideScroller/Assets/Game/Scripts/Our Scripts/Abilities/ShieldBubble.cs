using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBubble : MonoBehaviour
{
    [SerializeField]
    private float lifeTime = 3.0f;
    public float LifeTime
    {
        get { return lifeTime; }
    }

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shieldable"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.CompareTag("Spikes"))
        {
            other.gameObject.GetComponent<Spikes>().SetSpikeDmg();
        }
    }
}
