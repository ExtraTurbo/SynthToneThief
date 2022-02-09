using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStatus : MonoBehaviour
{
    // Properties
    public int Phase
    {
        get { return phase; }
        set { phase = value; }
    }

    public int NumPhases
    {
        get { return NUM_PHASES; }
    }

    [SerializeField]
    private int phase = 0; // phase 0 = b/w, 1 = red, 2 = blue, 3 = yellow
    
    private const int NUM_PHASES = 3; // number of instruments/pickups

    private void Awake()
    {
        if (tag != "Scripts")
        {
            tag = "Scripts";
            Debug.LogWarning("WorldStatus script assigned to object without the tag 'Scripts', tag has been assigned automatically", transform);
        }
    }
}
