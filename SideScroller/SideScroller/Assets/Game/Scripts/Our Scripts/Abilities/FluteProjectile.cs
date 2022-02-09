using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FluteProjectile : MonoBehaviour
{
    public Vector3 End
    {
        set { end = value; }
    }

    [SerializeField]
    protected float speed = 15.0f;
    [SerializeField]
    private float lifeTime = 0.25f;

    private Vector3 direction;
    private Vector3 end;

    // protected so it can be overwritten
    protected void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        if(Mathf.Abs(transform.position.x) >= Mathf.Abs(end.x) &&
            Mathf.Abs(transform.position.y) >= Mathf.Abs(end.y))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Growable"))
        {
            other.gameObject.GetComponent<Mushroom>().Scale();
            Destroy(gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        } 
    }

    // takes direction from function caller and sets bullet's direction to given value
    public void Fire(Vector3 dir)
    {
        direction = dir;
    }
}
