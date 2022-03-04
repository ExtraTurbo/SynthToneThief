using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarProjectile : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float lifeTime = 5.0f;

    private Vector3 direction;

    // protected so it can be overwritten
    private void OnEnable()
    {
        StartCoroutine(DisableTimer());
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            gameObject.SetActive(false);
        }
        else if(other.CompareTag("Breakable"))
        {
            if(other.TryGetComponent<HazardProjectile>(out HazardProjectile projectile))
            {
                other.gameObject.SetActive(false);
            }
            else
            {
                Destroy(other.gameObject);
            }

            gameObject.SetActive(false);
        }
    }

    // takes direction from function caller and sets bullet's direction to given value
    public void Fire(Vector3 dir)
    {
        direction = dir;
    }

    private IEnumerator DisableTimer()
    {
        yield return new WaitForSeconds(lifeTime);
        gameObject.SetActive(false);
    }
}
