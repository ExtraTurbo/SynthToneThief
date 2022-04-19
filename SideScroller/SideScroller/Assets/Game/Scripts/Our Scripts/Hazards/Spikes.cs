using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField]
    private Hazard hazardScript;

    private int damage;

    private void Start()
    {
        damage = hazardScript.damage;
    }

    public void SetSpikeDmg()
    {
        StartCoroutine(SpikeDmg());
    }

    private IEnumerator SpikeDmg()
    {
        hazardScript.damage = 0;
        yield return new WaitForSeconds(0.2f);
        hazardScript.damage = damage;
    }
}
