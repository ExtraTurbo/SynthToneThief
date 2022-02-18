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
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Spikes"))
        {
            StartCoroutine(SetSpikeDmg(other, other.GetComponent<Hazard>().damage));
        }
    }

    private IEnumerator SetSpikeDmg(Collider other, int dmg)
    {
        other.GetComponent<Hazard>().damage = 0;
        yield return new WaitForSeconds(0.15f);
        other.GetComponent<Hazard>().damage = dmg;
    }
}
