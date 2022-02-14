using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStatus : MonoBehaviour
{
    private int phase = 0; // phase 0 = b/w, 1 = red, 2 = blue, 3 = yellow
    public int Phase
    {
        get { return phase; }
        set { phase = value; }
    }

    private const int NUM_PHASES = 3; // number of instruments/pickups
    public int NumPhases
    {
        get { return NUM_PHASES; }
    }

    private void Awake()
    {
        if (tag != "Scripts")
        {
            tag = "Scripts";
            Debug.LogWarning("WorldStatus script assigned to object without the tag 'Scripts', tag has been assigned automatically", transform);
        }
    }
}
