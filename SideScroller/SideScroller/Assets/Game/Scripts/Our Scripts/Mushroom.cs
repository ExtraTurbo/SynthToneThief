using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField]
    private GameObject mushroomCap;
    [SerializeField]
    private GameObject mushroomStem;

    private bool grown;

    private void Awake()
    {
        grown = false;
    }

    public void Scale()
    {
        if(!grown)
        {
            mushroomStem.transform.localScale += new Vector3(0.15f, 1.75f, 0.15f);
            mushroomCap.transform.position += new Vector3(0.0f, 1.75f, 0.0f);
            mushroomCap.transform.localScale += new Vector3(0.75f, 0.1f, 0.75f);

            mushroomCap.GetComponent<BoxCollider>().enabled = true;
            gameObject.GetComponent<BoxCollider>().size += new Vector3(1.0f, 2.5f, 1.0f);
            grown = true;
        }
        else
        {
            mushroomStem.transform.localScale -= new Vector3(0.15f, 1.75f, 0.15f);
            mushroomCap.transform.position -= new Vector3(0.0f, 1.75f, 0.0f);
            mushroomCap.transform.localScale -= new Vector3(0.75f, 0.1f, 0.75f);

            mushroomCap.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<BoxCollider>().size -= new Vector3(1.0f, 2.5f, 1.0f);
            grown = false;
        }
    }
}
