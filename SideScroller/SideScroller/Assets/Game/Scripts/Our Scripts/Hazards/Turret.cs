using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;

    [SerializeField]
    private Transform fireLocation;

    [SerializeField]
    private float fireRate = 3.0f;

    [SerializeField]
    private float projectileSpeed = 5.0f;
    [SerializeField]
    private float projectileLifeTime = 5.0f;

    private Vector3 shootDirection;

    private void Start()
    {
        shootDirection = fireLocation.position - transform.position;
        shootDirection.z = 0.0f;
        shootDirection.Normalize();

        StartCoroutine(ShootProjectile());
    }

    private IEnumerator ShootProjectile()
    {
        yield return new WaitForSeconds(fireRate);

        GameObject projectileGO = GameObject.Instantiate(projectile, fireLocation.position, Quaternion.identity);
        HazardProjectile hazardProjectile = projectileGO.GetComponent<HazardProjectile>();

        hazardProjectile.LifeTime = projectileLifeTime;
        hazardProjectile.Speed = projectileSpeed;
        
        projectileGO.SetActive(true);
        hazardProjectile.Fire(shootDirection);

        StartCoroutine(ShootProjectile());
    }
}
