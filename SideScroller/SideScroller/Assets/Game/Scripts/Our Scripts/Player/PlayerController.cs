using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private WorldStatus world;
    [SerializeField]
    private PlayerBody playerBody;

    private void Update()
    {
        UpdateAim();
        CheckForFire();
    }

    private void CheckForFire()
    {
        bool checkForPrimaryFire = Input.GetButtonDown("Fire1");
        bool checkForSecondaryFire = Input.GetButtonDown("Fire2");
        bool checkForTertiaryFire = Input.GetButtonDown("Fire3");

        if(playerBody && world.Phase >= 3 && checkForTertiaryFire)
        {
            playerBody.Beam();
        }
        else if (playerBody && world.Phase >= 2 && checkForSecondaryFire)
        {
            playerBody.Shield();
        }
        else if (playerBody && world.Phase >= 1 && checkForPrimaryFire)
        {
            playerBody.Attack();
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
}
