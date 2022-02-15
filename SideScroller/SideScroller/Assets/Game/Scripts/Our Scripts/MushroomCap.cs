using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomCap : MonoBehaviour
{
    private bool isPushMushroom = false;
    public bool IsPushMushroom
    {
        get { return isPushMushroom; }
    }

    private GameObject pushing = null;
    public GameObject Pushing
    {
        get { return pushing; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Wall") && pushing == null)
        {
            isPushMushroom = true;
            pushing = collision.gameObject;

            Debug.Log("Pushing Object: " + collision.gameObject.name);
        }
    }
}
