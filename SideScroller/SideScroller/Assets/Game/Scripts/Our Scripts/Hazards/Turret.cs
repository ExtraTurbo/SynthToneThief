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

    private Vector3 shootDirection;

    private ObjectPoolManager.PoolTypes poolType;

    private void Start()
    {
        shootDirection = fireLocation.position - transform.position;
        shootDirection.z = 0.0f;
        shootDirection.Normalize();

        if(gameObject.CompareTag("RedTurret"))
        {
            poolType = ObjectPoolManager.PoolTypes.REDTURRET;
        }
        else if(gameObject.CompareTag("BlueTurret"))
        {
            poolType = ObjectPoolManager.PoolTypes.BLUETURRET;
        }
        else
        {
            poolType = ObjectPoolManager.PoolTypes.YELLOWTURRET;
        }

        StartCoroutine(ShootProjectile());
    }

    private IEnumerator ShootProjectile()
    {
        yield return new WaitForSeconds(fireRate);

        GameObject projectileGO = ObjectPoolManager.Instance.GetPooledObject(poolType);
        
        if(projectileGO != null)
        {
            HazardProjectile hazardProjectile = projectileGO.GetComponent<HazardProjectile>();

            hazardProjectile.transform.position = fireLocation.position;

            hazardProjectile.LifeTime = projectileLifeTime;
            hazardProjectile.Speed = projectileSpeed;

            projectileGO.SetActive(true);
            hazardProjectile.Fire(shootDirection);
        }
        else
        {
            Debug.Log("Null Projectile");
        }

        StartCoroutine(ShootProjectile());
    }
}
