using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardProjectile : MonoBehaviour
{
    private float speed;
    public float Speed
    {
        set { speed = value; }
    }

    private float lifeTime = 0;
    public float LifeTime
    {
        set { lifeTime = value; }
    }

    private Vector3 direction;

    [SerializeField]
    private AudioClip destructionSound;
    private AudioSource audioSource;

    private bool destroying = false;
    private CapsuleCollider collider;

    [SerializeField]
    private GameObject mesh;
    [SerializeField]
    private GameObject effect;

    private void Start()
    {
        TryGetComponent<AudioSource>(out audioSource);
        TryGetComponent<CapsuleCollider>(out collider);
    }

    protected void OnEnable()
    {
        if (mesh != null)
        {
            mesh.SetActive(true);
        }
        if (effect != null)
        {
            effect.SetActive(true);
        }
        if (collider != null)
        {
            collider.enabled = true;
        }
        
        StartCoroutine(DisableTimer());
    }

    protected void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    protected void OnTriggerEnter(Collider other)
    {
        // if the projectile hit the player, a wall,
        // or an object with the same tag (breakable, shieldable, growable),
        // disable the projectile
        if (other.CompareTag("Player") || other.CompareTag("Wall") || gameObject.tag == other.tag)
        {
            if(!other.CompareTag("Growable"))
            {
                if(other.TryGetComponent<GuitarProjectile>(out GuitarProjectile projectile))
                {
                    DestroyProjectile(true);
                }
                else
                {
                    DestroyProjectile(false);
                }
            }
        }
    }

    public void Fire(Vector3 dir)
    {
        direction = dir;
    }

    public void DestroyProjectile(bool playSound)
    {
        if(playSound)
        {
            StartCoroutine(PlayDestructionSound());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
    
    private IEnumerator DisableTimer()
    {
        yield return new WaitForSeconds(lifeTime);
        DestroyProjectile(false);
    }

    private IEnumerator PlayDestructionSound()
    {
        if (!destroying && gameObject.activeSelf)
        {
            destroying = true;
            mesh.SetActive(false);
            effect.SetActive(false);
            collider.enabled = false;

            if (audioSource != null && destructionSound != null)
            {
                audioSource.PlayOneShot(destructionSound, 0.6f);
            }
            yield return new WaitForSeconds(0.3f);

            gameObject.SetActive(false);
            destroying = false;
        }
        yield return null;
    }
}
