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

    [SerializeField]
    private Transform characterBody;

    [SerializeField]
    private GameObject fireLocation;
    [SerializeField]
    private Transform shieldLocation;

    [SerializeField]
    private float guitarCooldown = 0.5f;
    [SerializeField]
    private float shieldCooldown = 1.0f;
    [SerializeField]
    private float beamCooldown = 0.15f;
    [SerializeField]
    private float beamLifetime = 0.2f;
    [SerializeField]
    private float beamMaxLengthX = 8.0f;
    [SerializeField]
    private float beamMaxLengthY = 4.0f;
    [SerializeField]
    private Material beamMaterial;

    private bool guitarAvailable;
    private bool shieldAvailable;
    public bool ShieldAvailable
    {
        get { return shieldAvailable; }
    }
    private bool beamAvailable;
    private GameObject fluteBeam;

    private void Awake()
    {
        guitarAvailable = true;
        shieldAvailable = true;
        beamAvailable = true;
        fluteBeam = null;
    }

    private void Start()
    {
        if(beamMaterial == null)
        {
            Debug.LogError("There is no Material assigned for the Beam. Please assign a Material to the PlayerBody component (on Liam)!");
        }

        HUDManager.Instance.GuitarCooldown = guitarCooldown;
        HUDManager.Instance.DrumCooldown = 0.0f; // set in DrumShield coroutine
        HUDManager.Instance.FluteCooldown = beamCooldown + beamLifetime;
    }

    public void Attack()
    {
        if(guitarAvailable && fireLocation)
        {
            StartCoroutine(GuitarAtk());
        }
    }
    
    public void Shield()
    {
        if (shieldAvailable && fireLocation)
        {
            StartCoroutine(DrumShield());
        }
    }

    public void Beam()
    {
        if(fireLocation && beamAvailable)
        {
            StartCoroutine("BeamCast");
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
        GameObject bulletGO = ObjectPoolManager.Instance.GetPooledObject(ObjectPoolManager.PoolTypes.GUITARPROJECTILE);

        if (bulletGO != null)
        {
            bulletGO.transform.position = fireLocation.transform.position;
            bulletGO.GetComponent<GuitarProjectile>().SetMeshRotation();

            bulletGO.SetActive(true); // set bullet as active

            // set the direction of the bullet
            bulletGO.GetComponent<GuitarProjectile>().Fire(bulletDirection);

            HUDManager.Instance.CurrentGuitarCooldown = HUDManager.Instance.GuitarCooldown;
            yield return new WaitForSeconds(guitarCooldown);
        }

        guitarAvailable = true;
    }

    private IEnumerator DrumShield()
    {
        shieldAvailable = false;
        GameObject shieldGO = ObjectPoolManager.Instance.GetPooledObject(ObjectPoolManager.PoolTypes.SHIELD);
        shieldGO.SetActive(true);

        if(HUDManager.Instance.DrumCooldown == 0.0f)
        {
            HUDManager.Instance.DrumCooldown = shieldCooldown + shieldGO.GetComponent<ShieldBubble>().LifeTime;
            HUDManager.Instance.ShieldDuration = shieldGO.GetComponent<ShieldBubble>().LifeTime;
        }
        
        HUDManager.Instance.CurrentDrumCooldown = HUDManager.Instance.DrumCooldown;
        HUDManager.Instance.CurrentShieldDuration = HUDManager.Instance.ShieldDuration;
        
        while(shieldGO.activeSelf)
        {
            shieldGO.transform.position = shieldLocation.position;
            yield return null;
        }
        
        shieldAvailable = true;
    }

    private IEnumerator BeamCast()
    {
        beamAvailable = false;

        if (fluteBeam != null)
        {
            GameObject.Destroy(fluteBeam);
        }

        Vector3 startPos = fireLocation.transform.position;

        Vector3 direction = startPos - bodyPos.position;
        direction.z = 0.0f; // no movement in the z-axis
        direction.Normalize(); // normalize the direction of the raycast

        Plane plane = new Plane(Vector3.forward, startPos);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        plane.Raycast(ray, out float distanceToPlane);
        Vector3 mouseWorldPos = ray.GetPoint(distanceToPlane);

        // trying to limit the beam length??? ejrgbkajebgrj
        if (Mathf.Abs(mouseWorldPos.x - startPos.x) > beamMaxLengthX)
        {
            if (mouseWorldPos.x - startPos.x > 0)
            {
                mouseWorldPos.x = startPos.x + beamMaxLengthX;
            }
            else
            {
                mouseWorldPos.x = startPos.x - beamMaxLengthX;
            }
        }

        if (Mathf.Abs(mouseWorldPos.y - startPos.y) > beamMaxLengthY)
        {
            if (mouseWorldPos.y - startPos.y > 0)
            {
                mouseWorldPos.y = startPos.y + beamMaxLengthY;
            }
            else
            {
                mouseWorldPos.y = startPos.y - beamMaxLengthY;
            }
        }

        // create the beam game object
        fluteBeam = new GameObject();
        fluteBeam.transform.SetParent(gameObject.transform);
        fluteBeam.transform.position = bodyPos.position;
        fluteBeam.AddComponent<LineRenderer>();

        // add LineRenderer component to beam game object
        LineRenderer beam = fluteBeam.GetComponent<LineRenderer>();
        beam.material = beamMaterial;
        beam.widthMultiplier = 0.5f;
        beam.positionCount = 2;
        beam.SetPosition(0, startPos);
        beam.SetPosition(1, mouseWorldPos);

        // length of the beam, used as max distance the raycast should travel
        float beamLength = Mathf.Sqrt(Mathf.Pow(mouseWorldPos.x - startPos.x, 2) + Mathf.Pow(mouseWorldPos.y - startPos.y, 2));

        // send a ray from Liam to the Mouse World Position, check for collisions
        if (Physics.Raycast(startPos, direction, out RaycastHit hitInfo, beamLength))
        {
            //Debug.Log("Hit info: " + hitInfo.transform.name);

            // if the raycast hit an object tagged "Growable"
            if(hitInfo.collider.CompareTag("GuitarProjectile") || (!hitInfo.collider.CompareTag("Growable") && !hitInfo.collider.transform.parent.CompareTag("Growable")))
            {
                // hit something irrelevant
            }
            else if (hitInfo.collider.CompareTag("Growable") || hitInfo.collider.transform.parent.CompareTag("Growable"))
            {
                // try to get a "Mushroom" component (script) from that object
                if (hitInfo.collider.TryGetComponent<Mushroom>(out Mushroom component))
                {
                    // call the Scale function (grow/shrink the mushroom)
                    component.Scale();
                }
                else if (hitInfo.collider.transform.parent != null)
                {
                    // try to find a Mushroom component (script) on the object's parent
                    // (in case we hit the cap/stem colliders instead of the mushroom's collider)
                    // if the parent has a Mushroom component, call the Scale function
                    if (hitInfo.collider.gameObject.transform.parent.TryGetComponent<Mushroom>(out Mushroom parent))
                    {
                        parent.Scale();
                    }
                }
            }
            
        }
        // start the beam ability's cooldown timer
        StartCoroutine("BeamCooldown");
        yield return null;
    }

    private IEnumerator BeamCooldown()
    {
        HUDManager.Instance.CurrentFluteCooldown = HUDManager.Instance.FluteCooldown;
        yield return new WaitForSeconds(beamLifetime);

        LineRenderer.Destroy(fluteBeam.GetComponent<LineRenderer>());
        GameObject.Destroy(fluteBeam);
        fluteBeam = null;

        yield return new WaitForSeconds(beamCooldown);
        beamAvailable = true;
    }
}
