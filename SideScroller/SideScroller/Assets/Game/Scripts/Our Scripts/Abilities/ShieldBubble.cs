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

    [SerializeField]
    private AudioClip shieldOnClip;
    [SerializeField]
    private AudioClip shieldOffClip;

    [SerializeField]
    private float horizontalPushForce = 30.0f;

    private AudioSource audioSource;

    private CapsuleCollider c;
    private MeshRenderer mesh;

    private GameObject player;

    private bool destroying = false;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        TryGetComponent<AudioSource>(out audioSource);
        TryGetComponent<CapsuleCollider>(out c);
        TryGetComponent<MeshRenderer>(out mesh);
    }

    private void OnEnable()
    {
        if (mesh != null)
        {
            mesh.enabled = true;
        }
        if (c != null)
        {
            c.enabled = true;
        }
        
        StartCoroutine(UptimeCountdown());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shieldable"))
        {
            other.gameObject.SetActive(false);
            DestroyShield();
        }
        else if (other.CompareTag("Spikes"))
        {
            other.gameObject.GetComponent<Spikes>().SetSpikeDmg();
            DestroyShield();
            if (Mathf.Abs(player.transform.position.x - other.gameObject.transform.position.x) > 1.0f)
            {
                if (player.TryGetComponent<Rigidbody>(out Rigidbody rb))
                {
                    float xDir = player.transform.position.x - other.gameObject.transform.position.x;
                    rb.AddForce(new Vector3(xDir, 0.0f, 0.0f).normalized * horizontalPushForce, ForceMode.VelocityChange);
                }
            }
        }
    }

    private IEnumerator UptimeCountdown()
    {
        yield return new WaitForSeconds(lifeTime);
        DestroyShield();
    }

    private IEnumerator PopShield()
    {
        yield return new WaitForSeconds(0.05f);
        gameObject.SetActive(false);
        destroying = false;
        StopAllCoroutines();
    }

    public void DestroyShield()
    {
        StartCoroutine(ShieldDestruction());
    }

    private IEnumerator ShieldDestruction()
    {
        if (!destroying)
        {
            destroying = true;
            if (audioSource != null && shieldOffClip != null)
            {
                mesh.enabled = false;
                c.enabled = false;
                audioSource.PlayOneShot(shieldOffClip, 0.8f);
                yield return new WaitForSeconds(0.3f);
            }
            StartCoroutine(PopShield());
        }
        yield return null;
    }
}
