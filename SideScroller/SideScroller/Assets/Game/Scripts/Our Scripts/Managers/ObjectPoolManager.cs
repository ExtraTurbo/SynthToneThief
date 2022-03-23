using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    private static ObjectPoolManager instance = null;
    public static ObjectPoolManager Instance
    {
        get { return instance; }
    }

    public enum PoolTypes { REDTURRET, BLUETURRET, YELLOWTURRET, GUITARPROJECTILE, SHIELD }

    [SerializeField]
    private ObjectPool[] objectPools; // order must match order of enum pool types

    private void Awake()
    {
        instance = this;
    }

    public GameObject GetPooledObject(PoolTypes type)
    {
        return objectPools[(int)type].GetPooledObject();
    }

    public void Reset()
    {
        foreach (ObjectPool op in objectPools)
        {
            op.Reset();
        }
    }
}
