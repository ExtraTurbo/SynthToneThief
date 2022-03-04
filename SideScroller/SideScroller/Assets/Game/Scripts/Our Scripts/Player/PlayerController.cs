using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private WorldStatus world;

    [SerializeField]
    private PlayerBody playerBody;
    [SerializeField]
    private float globalCooldown = 0.1f;

    private bool gcd = false;

    private void Start()
    {
        world = WorldStatus.Instance;
    }

    private void Update()
    {
        UpdateAim();
        CheckForFire();
    }

    private void CheckForFire()
    {
        if(!gcd)
        {
            bool checkForPrimaryFire = Input.GetButtonDown("Fire1");
            bool checkForSecondaryFire = Input.GetButtonDown("Fire2");
            bool checkForTertiaryFire = Input.GetButtonDown("Fire3");

            if (playerBody && world.Phase >= 3 && checkForTertiaryFire)
            {
                gcd = true;
                playerBody.Beam();
                StartCoroutine(GlobalCooldown());
            }
            else if (playerBody && world.Phase >= 2 && checkForSecondaryFire)
            {
                gcd = true;
                playerBody.Shield();
                StartCoroutine(GlobalCooldown());
            }
            else if (playerBody && world.Phase >= 1 && checkForPrimaryFire)
            {
                gcd = true;
                playerBody.Attack();
                StartCoroutine(GlobalCooldown());
            }
        }
    }

    private void UpdateAim()
    {
        Plane plane = new Plane(Vector3.forward, playerBody.BodyPos.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distanceToPlane;

        plane.Raycast(ray, out distanceToPlane); // 'out' keyword tells us the function will set the variable (distanceToPlane)
        Vector3 mouseWorldPos = ray.GetPoint(distanceToPlane);

        Vector3 aimDir = mouseWorldPos - playerBody.transform.position;
        aimDir.z = 0.0f; // not allowing movement in z-axis

        playerBody.UpdateAimDirection(aimDir);
    }

    private IEnumerator GlobalCooldown()
    {
        yield return new WaitForSeconds(globalCooldown);
        gcd = false;
    }
}
