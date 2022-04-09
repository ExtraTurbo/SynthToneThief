using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentPickups : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem instrumentEffect;

    [SerializeField]
    private GameObject instrumentModel;

    [SerializeField]
    private AudioClip pickupSoundClip;

    [SerializeField]
    private AudioSource playerAudioSource;

    private void Start()
    {
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
            StartCoroutine(Destroy());
        }
    }

    private IEnumerator Destroy()
    {
        instrumentEffect.Play();
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        instrumentModel.SetActive(false);
        SetPhase();
        yield return new WaitForSeconds(1.0f);
        Destroy(gameObject);
    }

    private void SetPhase()
    {
        if (gameObject.tag == "GuitarPickup")
        {
            WorldStatus.Instance.Phase = 1;
            PlayPickupSound();
        }
        else if (gameObject.tag == "DrumPickup")
        {
            WorldStatus.Instance.Phase = 2;
            PlayPickupSound();
        }
        else if (gameObject.tag == "FlutePickup")
        {
            WorldStatus.Instance.Phase = 3;
            PlayPickupSound();
        }
    }

    private void PlayPickupSound()
    {
        if (pickupSoundClip != null)
        {
            playerAudioSource.PlayOneShot(pickupSoundClip, 0.8f);
        }
    }
}
