using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    private static HUDManager instance;
    public static HUDManager Instance
    {
        get { return instance; }
    }

    // GUITAR VALUES //
    [SerializeField]
    private Text guitarCooldownText;

    private float guitarCooldown;
    public float GuitarCooldown
    {
        set { guitarCooldown = value; }
        get { return guitarCooldown; }
    }

    private float currentGuitarCooldown;
    public float CurrentGuitarCooldown
    {
        set { currentGuitarCooldown = value; }
    }

    // DRUM VALUES //
    [SerializeField]
    private Text drumCooldownText;

    private float drumCooldown;
    public float DrumCooldown
    {
        set { drumCooldown = value; }
        get { return drumCooldown; }
    }

    private float currentDrumCooldown;
    public float CurrentDrumCooldown
    {
        set { currentDrumCooldown = value; }
    }

    // FLUTE VALUES //
    [SerializeField]
    private Text fluteCooldownText;

    private float fluteCooldown;
    public float FluteCooldown
    {
        set { fluteCooldown = value; }
        get { return fluteCooldown; }
    }

    private float currentFluteCooldown;
    public float CurrentFluteCooldown
    {
        set { currentFluteCooldown = value; }
    }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        guitarCooldownText.text = "";
        drumCooldownText.text = "";
        fluteCooldownText.text = "";
    }

    private void Update()
    {
        if(WorldStatus.Instance.Phase >= 1)
        {
            UpdateGuitarTimer();

            if(WorldStatus.Instance.Phase >= 2)
            {
                UpdateDrumTimer();

                if(WorldStatus.Instance.Phase == 3)
                {
                    UpdateFluteTimer();
                }
            }
        }
    }

    private void UpdateGuitarTimer()
    {
        currentGuitarCooldown = Mathf.Clamp(currentGuitarCooldown, 0.0f, guitarCooldown);

        if (currentGuitarCooldown != 0)
        {
            currentGuitarCooldown -= Time.deltaTime;
            currentGuitarCooldown = Mathf.Clamp(currentGuitarCooldown, 0.0f, guitarCooldown);

            if (currentGuitarCooldown != 0)
            {
                guitarCooldownText.text = currentGuitarCooldown.ToString("0.0");
            }
            else
            {
                guitarCooldownText.text = "";
            }
        }
        else
        {
            guitarCooldownText.text = "";
        }
    }

    private void UpdateDrumTimer()
    {
        currentDrumCooldown = Mathf.Clamp(currentDrumCooldown, 0.0f, drumCooldown);

        if (currentDrumCooldown != 0)
        {
            currentDrumCooldown -= Time.deltaTime;
            currentDrumCooldown = Mathf.Clamp(currentDrumCooldown, 0.0f, drumCooldown);

            if (currentDrumCooldown != 0)
            {
                drumCooldownText.text = currentDrumCooldown.ToString("0.0");
            }
            else
            {
                drumCooldownText.text = "";
            }
        }
        else
        {
            drumCooldownText.text = "";
        }
    }

    private void UpdateFluteTimer()
    {
        currentFluteCooldown = Mathf.Clamp(currentFluteCooldown, 0.0f, fluteCooldown);

        if(currentFluteCooldown != 0)
        {
            currentFluteCooldown -= Time.deltaTime;
            currentFluteCooldown = Mathf.Clamp(currentFluteCooldown, 0.0f, fluteCooldown);

            if(currentFluteCooldown != 0)
            {
                fluteCooldownText.text = currentFluteCooldown.ToString("0.0");
            }
            else
            {
                fluteCooldownText.text = "";
            }
        }
        else
        {
            fluteCooldownText.text = "";
        }
    }
}
