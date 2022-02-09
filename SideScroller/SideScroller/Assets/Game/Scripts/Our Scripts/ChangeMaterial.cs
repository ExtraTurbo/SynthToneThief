using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField]
    private WorldStatus world;
    [SerializeField]
    private Material redMat;
    [SerializeField]
    private Material blueMat;
    [SerializeField]
    private Material yellowMat;

    private int phase;
    private int currentPhase;
    private GameObject[] objects;

    private void Start()
    {
        phase = world.Phase;
        currentPhase = phase;
        objects = GameObject.FindGameObjectsWithTag("ChangeColour");

        StartCoroutine(CheckPhase());
    }

    private void UpdateMats()
    {
        // Update objects' applied material (colour) according to the phase (pickups collected)
        switch (phase)
        {
            case 1:
                foreach (GameObject obj in objects)
                {
                    obj.GetComponent<MeshRenderer>().material = redMat;
                }
                break;
            case 2:
                foreach (GameObject obj in objects)
                {
                    obj.GetComponent<MeshRenderer>().material = blueMat;
                }
                break;
            default:
                foreach (GameObject obj in objects)
                {
                    obj.GetComponent<MeshRenderer>().material = yellowMat;
                }
                break;

        }
        // Update current phase #
        currentPhase = phase;
    }

    IEnumerator CheckPhase()
    {
        while(phase < world.NumPhases)
        {
            phase = world.Phase;
            if (phase != currentPhase)
            {
                UpdateMats();
            }
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
    }
}
