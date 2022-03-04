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

    protected void OnEnable()
    {
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
                gameObject.SetActive(false);
            }
        }
    }

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
