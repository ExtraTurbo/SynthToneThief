using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private static ObjectPool instance = null;
    public static ObjectPool Instance
    {
        get { return instance; }
    }

    [SerializeField]
    private GameObject pooledObjectPrefab; // the pooled object
    [SerializeField]
    private int pooledAmount = 20; // how many objects we need
    [SerializeField]
    bool willGrow = false;

    private List<GameObject> pooledObjects; // the pool

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();

        // create the pooled objects
        for(int i=0; i < pooledAmount; i++)
        {
            CreatePooledObject();
        }
    }

    private GameObject CreatePooledObject()
    {
        GameObject obj = Instantiate(pooledObjectPrefab);
        obj.SetActive(false);
        obj.transform.SetParent(transform); // set instantiated prefab obj parent to this obj (ObjectPool GO)
        
        pooledObjects.Add(obj); // add object to list of pooled objects

        return obj;
    }

    public GameObject GetPooledObject()
    {
        GameObject poolObj = null;

        // find first inactive object in pool
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                poolObj = obj;
                break;
            }
        }

        // if we couldn't find an inactive obj in pool & pool can grow, make another one
        if (poolObj == null && willGrow)
        {
            return CreatePooledObject();
        }
        else if (poolObj == null)
        {
            Debug.LogError("Object Pool for: " + pooledObjectPrefab.name + " is not large enough!");
        }

        return poolObj;
    }

    public void Reset()
    {
        foreach (GameObject obj in pooledObjects)
        {
            obj.SetActive(false);
        }
    }
}
