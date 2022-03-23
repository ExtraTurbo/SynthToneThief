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

    void OnEnable()
    {
        StartCoroutine(UptimeCountdown());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shieldable"))
        {
            other.gameObject.SetActive(false);
            StartCoroutine(PopShield());
        }
        else if (other.CompareTag("Spikes"))
        {
            other.gameObject.GetComponent<Spikes>().SetSpikeDmg();
            StartCoroutine(PopShield());
        }
    }

    private IEnumerator UptimeCountdown()
    {
        yield return new WaitForSeconds(lifeTime);
        gameObject.SetActive(false);
        StopAllCoroutines();
    }

    private IEnumerator PopShield()
    {
        yield return new WaitForSeconds(0.05f);
        gameObject.SetActive(false);
        StopAllCoroutines();
    }
}
