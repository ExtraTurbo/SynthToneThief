using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    [SerializeField]
    private Transform bodyPos;
    public Transform BodyPos
    {
        get { return bodyPos; }
    }

    private static bool shieldAvailable;
    public static bool ShieldAvailable
    {
        set { shieldAvailable = value; }
        get { return shieldAvailable; }
    }

    [SerializeField]
    private Transform CharacterBody;
    [SerializeField]
    private GameObject guitarProjectile;
    [SerializeField]
    private GameObject shieldBubble;
    [SerializeField]
    private GameObject fluteProjectile;
    [SerializeField]
    private GameObject fireLocation;

    [SerializeField]
    private float guitarCooldown;
    [SerializeField]
    private float beamLifetime = 0.25f;

    private bool guitarAvailable;
    private static bool beamAvailable;
    private GameObject fluteBeam;

    private void Awake()
    {
        guitarAvailable = true;
        shieldAvailable = true;
        beamAvailable = true;
        fluteBeam = null;
    }

    public void Attack()
    {
        if(guitarAvailable && guitarProjectile && fireLocation)
        {
            StartCoroutine(GuitarAtk());
        }
    }
    
    public void Shield()
    {
        if (shieldAvailable && shieldBubble && fireLocation)
        {
            GameObject shieldGO = GameObject.Instantiate(shieldBubble, CharacterBody.transform);
            shieldGO.SetActive(true);
        }
    }

    public void Beam()
    {
        if(fireLocation && beamAvailable)
        {
            beamAvailable = false;

            Plane plane = new Plane(Vector3.forward, fireLocation.transform.position);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            plane.Raycast(ray, out float distanceToPlane);
            Vector3 mouseWorldPos = ray.GetPoint(distanceToPlane);

            fluteBeam = new GameObject();
            fluteBeam.transform.SetParent(gameObject.transform);
            fluteBeam.tag = "Beam";
            fluteBeam.transform.position = bodyPos.position;
            fluteBeam.AddComponent<LineRenderer>();
            LineRenderer beam = fluteBeam.GetComponent<LineRenderer>();

            //beam.useWorldSpace = true;
            beam.material = fluteProjectile.GetComponent<Renderer>().sharedMaterial;
            //beam.startColor = Color.white;
            //beam.endColor = Color.white;
            beam.widthMultiplier = 0.5f;
            beam.positionCount = 2;
            beam.SetPosition(0, fireLocation.transform.position);
            beam.SetPosition(1, mouseWorldPos);

            Vector3 bulletStartPos = fireLocation.transform.position;
            Vector3 bulletDirection = bulletStartPos - bodyPos.position;

            bulletDirection.z = 0.0f; // no movement in the z-axis
            bulletDirection.Normalize(); // normalize the direction of the bullet

            // instantiate a new projectile
            GameObject bulletGO = GameObject.Instantiate(fluteProjectile, bulletStartPos, Quaternion.identity);
            bulletGO.GetComponent<FluteProjectile>().End = mouseWorldPos;
            bulletGO.SetActive(true); // set bullet as active

            // set the direction of the bullet
            bulletGO.GetComponent<FluteProjectile>().Fire(bulletDirection);

            StartCoroutine("BeamCooldown");
        }
    }
    
    public void UpdateAimDirection(Vector3 aimDir)
    {
        aimDir.Normalize(); // only a direction, no distance information
        bodyPos.rotation = Quaternion.LookRotation(aimDir); // converts passed in Vector3 into a Quaternion
    }

    private IEnumerator GuitarAtk()
    {
        guitarAvailable = false;

        Vector3 bulletStartPos = fireLocation.transform.position;

        // get direction player is facing
        Vector3 bulletDirection = bulletStartPos - bodyPos.position;

        bulletDirection.z = 0.0f; // no movement in the z-axis
        bulletDirection.Normalize(); // normalize the direction of the bullet

        // instantiate a new projectile
        GameObject bulletGO = GameObject.Instantiate(guitarProjectile, bulletStartPos, Quaternion.identity);
        bulletGO.SetActive(true); // set bullet as active

        // set the direction of the bullet
        bulletGO.GetComponent<GuitarProjectile>().Fire(bulletDirection);

        yield return new WaitForSeconds(guitarCooldown);

        guitarAvailable = true;
    }

    private IEnumerator BeamCooldown()
    {
        yield return new WaitForSeconds(beamLifetime);
        GameObject.Destroy(fluteBeam);
        beamAvailable = true;
    }
}
