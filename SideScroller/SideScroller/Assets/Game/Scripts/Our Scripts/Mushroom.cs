using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    [SerializeField]
    private GameObject mushroomCap;
    [SerializeField]
    private GameObject mushroomStem;

    [SerializeField]
    private GameObject mushroomMesh;

    [SerializeField]
    private float growthXZ = 5.0f;
    [SerializeField]
    private float growthY = 5.0f;
    [SerializeField]
    private float translateY = 2.5f;

    [SerializeField]
    private float growSpeed = 1.5f;

    [SerializeField]
    private float playerDistanceToShrinkPhysicsShroom = 2.5f;

    public bool Grown
    {
        get { return grown; }
    }
    private bool grown;

    public bool Growing
    {
        get { return growing; }
    }
    private bool growing;

    public bool Shrinkable
    {
        set { shrinkable = value; }
    }
    private bool shrinkable;

    Vector3 stemScale;
    Vector3 capScale;
    Vector3 capPosition;
    Vector3 meshScale;
    Vector3 meshPosition;

    private Quaternion rot;

    private GameObject player;
    private float playerDistanceX;
    private float playerDistanceY;

    private void Awake()
    {
        grown = false;
        growing = false;
        shrinkable = true;
        stemScale = mushroomStem.transform.localScale;
        capScale = mushroomCap.transform.localScale;
        capPosition = mushroomCap.transform.position;
        meshScale = mushroomMesh.transform.localScale;
        meshPosition = mushroomMesh.transform.position;
        rot = transform.rotation;

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == gameObject.tag && (grown || growing))
        {
            other.gameObject.SetActive(false);
        }
    }

    public void Scale()
    {
        if(!growing)
        {
            if (!grown)
            {
                StartCoroutine(Grow());
            }
            else if(shrinkable)
            {
                StartCoroutine(Shrink());
            }
            else
            {
                playerDistanceX = Mathf.Abs(gameObject.transform.position.x - player.transform.position.x);
                playerDistanceY = Mathf.Abs(gameObject.transform.position.y - player.transform.position.y);
                //Debug.Log("Player Distance X from Physics Shroom: " + playerDistanceX.ToString());
                //Debug.Log("Player Distance Y from Physics Shroom: " + playerDistanceY.ToString());
                if (playerDistanceX > playerDistanceToShrinkPhysicsShroom || playerDistanceY > playerDistanceToShrinkPhysicsShroom)
                {
                    StartCoroutine(Shrink());
                }
            }
        }
    }

    private IEnumerator Grow()
    {
        growing = true;
        float timeElapsed = 0.0f;
        Vector3 stemStart = stemScale;
        Vector3 capStart = capScale;
        Vector3 capPosStart = capPosition;
        Vector3 meshStart = meshScale;
        Vector3 meshPosStart = meshPosition;
        Vector3 mushroomPosStart = gameObject.transform.position;
        Vector3 colliderStart = gameObject.GetComponent<BoxCollider>().size;

        MushroomCap mushCapScript = mushroomCap.GetComponent<MushroomCap>();
        Vector3 distanceCapWall = new Vector3();

        if (mushCapScript.IsPushMushroom && mushCapScript.Pushing != null)
        {
            distanceCapWall = mushCapScript.Pushing.transform.position - capPosStart;
            //Debug.Log("Distance Cap Wall = " + distanceCapWall);

            if(distanceCapWall.x >= 3.0f)
            {
                mushCapScript.ResetPushing();
            }
        }

        mushroomCap.GetComponent<BoxCollider>().enabled = true;

        while (timeElapsed < growSpeed)
        {
            //stemScale = Vector3.Lerp(stemStart, stemStart + new Vector3(0.1f, 1.4f, 0.1f), timeElapsed / growSpeed);
            //mushroomStem.transform.localScale = stemScale;
            
            capScale = Vector3.Lerp(capStart, capStart + new Vector3(0.9f, 0.1f, 0.9f), timeElapsed / growSpeed);
            mushroomCap.transform.localScale = capScale;

            meshScale = Vector3.Lerp(meshStart, meshStart + new Vector3(growthXZ, growthY, growthXZ), timeElapsed / growSpeed);
            mushroomMesh.transform.localScale = meshScale;

            Debug.Log("Euler Rot Z: " + rot.eulerAngles.z.ToString());

            switch(Mathf.RoundToInt(rot.eulerAngles.z))
            {
                case 90:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart - new Vector3(2.4f, 0.0f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart - new Vector3(1.25f, 0.0f, 0.0f), timeElapsed / growSpeed);

                    break;
                case 270:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart + new Vector3(2.4f, 0.0f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart + new Vector3(1.25f, 0.0f, 0.0f), timeElapsed / growSpeed);

                    break;
                case 145:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart - new Vector3(1.3f, 1.75f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart - new Vector3(0.75f, 0.75f, 0.0f), timeElapsed / growSpeed);

                    break;
                default:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart + new Vector3(0.0f, 2.5f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    meshPosition = Vector3.Lerp(meshPosStart, meshPosStart + new Vector3(0.0f, translateY, 0.0f), timeElapsed / growSpeed);
                    mushroomMesh.transform.position = meshPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart + new Vector3(0.0f, 0.75f, 0.0f), timeElapsed / growSpeed);

                    break;
            }

            gameObject.GetComponent<BoxCollider>().size = Vector3.Lerp(colliderStart, colliderStart + new Vector3(2.0f, 3.8f, 2.0f), timeElapsed / growSpeed);

            if (distanceCapWall != new Vector3() && mushCapScript.Pushing)
            {
                mushCapScript.Pushing.transform.position = mushroomCap.transform.position + distanceCapWall;
            }

            timeElapsed += Time.deltaTime;
            yield return null;
        }
        grown = true;
        growing = false;
    }

    private IEnumerator Shrink()
    {
        growing = true;
        float timeElapsed = 0.0f;
        Vector3 stemStart = stemScale;
        Vector3 capStart = capScale;
        Vector3 capPosStart = capPosition;
        Vector3 meshStart = meshScale;
        Vector3 meshPosStart = meshPosition;
        Vector3 mushroomPosStart = gameObject.transform.position;
        Vector3 colliderStart = gameObject.GetComponent<BoxCollider>().size;

        MushroomCap mushCapScript = mushroomCap.GetComponent<MushroomCap>();
        Vector3 distanceCapWall = new Vector3();

        if(mushCapScript.IsPushMushroom && mushCapScript.Pushing != null)
        {
            distanceCapWall = mushCapScript.Pushing.transform.position - capPosStart;
            //Debug.Log("Distance Cap Wall = " + distanceCapWall);
        }

        while (timeElapsed < growSpeed)
        {
            //stemScale = Vector3.Lerp(stemStart, stemStart - new Vector3(0.1f, 1.4f, 0.1f), timeElapsed / growSpeed);
            //mushroomStem.transform.localScale = stemScale;

            capScale = Vector3.Lerp(capStart, capStart - new Vector3(0.9f, 0.1f, 0.9f), timeElapsed / growSpeed);
            mushroomCap.transform.localScale = capScale;

            meshScale = Vector3.Lerp(meshStart, meshStart - new Vector3(growthXZ, growthY, growthXZ), timeElapsed / growSpeed);
            mushroomMesh.transform.localScale = meshScale;

            switch (Mathf.RoundToInt(rot.eulerAngles.z))
            {
                case 90:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart + new Vector3(2.4f, 0.0f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart + new Vector3(1.25f, 0.0f, 0.0f), timeElapsed / growSpeed);

                    break;
                case 270:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart - new Vector3(2.4f, 0.0f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart - new Vector3(1.25f, 0.0f, 0.0f), timeElapsed / growSpeed);

                    break;
                case 145:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart + new Vector3(1.3f, 1.75f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart + new Vector3(0.75f, 0.75f, 0.0f), timeElapsed / growSpeed);

                    break;
                default:
                    capPosition = Vector3.Lerp(capPosStart, capPosStart - new Vector3(0.0f, 2.5f, 0.0f), timeElapsed / growSpeed);
                    mushroomCap.transform.position = capPosition;

                    meshPosition = Vector3.Lerp(meshPosStart, meshPosStart - new Vector3(0.0f, translateY, 0.0f), timeElapsed / growSpeed);
                    mushroomMesh.transform.position = meshPosition;

                    gameObject.transform.position = Vector3.Lerp(mushroomPosStart, mushroomPosStart - new Vector3(0.0f, 0.75f, 0.0f), timeElapsed / growSpeed);

                    break;
            }

            gameObject.GetComponent<BoxCollider>().size = Vector3.Lerp(colliderStart, colliderStart - new Vector3(2.0f, 3.8f, 2.0f), timeElapsed / growSpeed);

            timeElapsed += Time.deltaTime;
            yield return null;
        }

        if(!mushCapScript.Pushing)
        {
            mushroomCap.GetComponent<BoxCollider>().enabled = false;
        }

        grown = false;
        growing = false;
    }
}
