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

    private float lifeTime;
    public float LifeTime
    {
        set { lifeTime = value; }
    }

    private Vector3 direction;

    protected void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    protected void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

        }
        else if (other.CompareTag("Wall") || gameObject.tag == other.tag)
        {
            Destroy(gameObject);
        }
    }

    public void Fire(Vector3 dir)
    {
        direction = dir;
    }
}
