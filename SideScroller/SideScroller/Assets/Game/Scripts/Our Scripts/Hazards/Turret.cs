using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private Transform fireLocation;

    [SerializeField]
    private float fireRate = 3.0f;

    [SerializeField]
    private float projectileSpeed = 5.0f;
    [SerializeField]
    private float projectileLifeTime = 5.0f;

    [SerializeField]
    private float playerDistanceStartShootingX = 65.0f;
    [SerializeField]
    private float playerDistanceStartShootingY = 65.0f;

    [SerializeField]
    private ParticleSystem fireEffect;

    [SerializeField]
    private bool destroyable = false;

    [SerializeField]
    private GameObject undestroyableEffect;

    private Vector3 shootDirection;

    private ObjectPoolManager.PoolTypes poolType;

    private GameObject player;
    private bool shooting;

    [SerializeField]
    private GameObject meshes;

    // Audio
    public AudioSource turretSource = null;
    [SerializeField]
    private AudioClip destroyClip;


    private void Start()
    {
        // Audio
        if (!TryGetComponent<AudioSource>(out turretSource))
        {
            // only disabling this for the time being for testing
            //Debug.LogError("No AudioSource found");
        }

        player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
        {
            Debug.LogError("Null Player in Turret script");
        }

        shootDirection = fireLocation.position - transform.position;
        shootDirection.z = 0.0f;
        shootDirection.Normalize();

        if (gameObject.CompareTag("RedTurret"))
        {
            poolType = ObjectPoolManager.PoolTypes.REDTURRET;
        }
        else if (gameObject.CompareTag("BlueTurret"))
        {
            poolType = ObjectPoolManager.PoolTypes.BLUETURRET;
        }
        else
        {
            poolType = ObjectPoolManager.PoolTypes.YELLOWTURRET;
        }

        //See if the turret is not destroyable
        if(destroyable == false && gameObject.CompareTag("RedTurret"))
        {
            undestroyableEffect.SetActive(true);
        }

        shooting = false;
        StartCoroutine(ShootProjectile());
    }

    private void Update()
    {
        float distanceX = Mathf.Abs(gameObject.transform.position.x - player.transform.position.x);
        float distanceY = Mathf.Abs(gameObject.transform.position.y - player.transform.position.y);

        if (!shooting && (distanceX <= playerDistanceStartShootingX && distanceY <= playerDistanceStartShootingY))
        {
            shooting = true;
        }
        else if (shooting && (distanceX > playerDistanceStartShootingX || distanceY > playerDistanceStartShootingY))
        {
            shooting = false;
        }
    }

    private IEnumerator ShootProjectile()
    {
        if (shooting)
        {
            yield return new WaitForSeconds(fireRate);

            fireEffect.Play();

            GameObject projectileGO = ObjectPoolManager.Instance.GetPooledObject(poolType);

            if (projectileGO != null)
            {
                HazardProjectile hazardProjectile = projectileGO.GetComponent<HazardProjectile>();
                hazardProjectile.transform.position = fireLocation.position;
                hazardProjectile.LifeTime = projectileLifeTime;
                hazardProjectile.Speed = projectileSpeed;

                projectileGO.SetActive(true);
                hazardProjectile.Fire(shootDirection);

                // Audio
                PlayShootingSound();
            }
            else
            {
                Debug.Log("Null Projectile");
            }
        }
        else
        {
            yield return new WaitForSeconds(0.1f);
        }

        StartCoroutine(ShootProjectile());
    }

    void PlayShootingSound()
    {
        turretSource.volume = 0.3f;
        turretSource.pitch = Random.Range(0.7f, 1.3f);
        turretSource.PlayOneShot(turretSource.clip);
    }

    //Code to allow Guitar projectiles to destroy the turret
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GuitarProjectile") && destroyable == true && gameObject.CompareTag("RedTurret"))
        {
            if (other.gameObject.TryGetComponent<GuitarProjectile>(out GuitarProjectile projectile))
            {
                projectile.gameObject.SetActive(false);
            }
            else if (other.gameObject.transform.parent != null &&
                     other.gameObject.transform.parent.TryGetComponent<GuitarProjectile>(out GuitarProjectile projectile2))
            {
                projectile2.gameObject.SetActive(false);
            }
            StartCoroutine(PlayDestroySound());
        }
    }

    private IEnumerator PlayDestroySound()
    {
        if (turretSource != null && destroyClip != null)
        {
            if (meshes != null)
            {
                meshes.SetActive(false);
            }
            turretSource.PlayOneShot(destroyClip, 1.0f);
            yield return new WaitForSeconds(0.2f);
        }
        Destroy(gameObject);
    }
}
