using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentPickups : MonoBehaviour
{
    [SerializeField]
    private WorldStatus world;

    private void Awake()
    {
        if(world == null)
        {
            Debug.Log("'InstrumentPickup' script is missing 'WorldStatus' script -- assign in Inspector");
        }
        if (gameObject.tag == null)
        {
            Debug.Log("This instrument pickup (" + gameObject + ") does not have a tag!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if Player collided with Pickup
        if(other.CompareTag("Player"))
        {
            // Destroy the pickup
            Object.Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        if(gameObject.tag == "GuitarPickup")
        {
            world.Phase = 1;
        }
        else if(gameObject.tag == "DrumPickup")
        {
            world.Phase = 2;
        }
        else if(gameObject.tag == "FlutePickup")
        {
            world.Phase = 3;
        }
    }
}
