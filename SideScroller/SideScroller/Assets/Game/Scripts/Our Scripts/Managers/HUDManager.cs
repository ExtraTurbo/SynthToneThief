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
    [SerializeField]
    private Image guitarAbilityImage;
    [SerializeField]
    private Sprite guitarUnlockSprite;

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

    private bool guitarUnlock;

    // DRUM VALUES //
    [SerializeField]
    private Text drumCooldownText;
    [SerializeField]
    private Image drumAbilityImage;
    [SerializeField]
    private Sprite drumUnlockSprite;

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

    private bool drumUnlock;

    // FLUTE VALUES //
    [SerializeField]
    private Text fluteCooldownText;
    [SerializeField]
    private Image fluteAbilityImage;
    [SerializeField]
    private Sprite fluteUnlockSprite;

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

    private bool fluteUnlock;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        guitarCooldownText.text = "";
        drumCooldownText.text = "";
        fluteCooldownText.text = "";

        guitarUnlock = false;
        drumUnlock = false;
        fluteUnlock = false;
    }

    private void Update()
    {
        if(WorldStatus.Instance.Phase >= 1)
        {
            if(guitarUnlock == false)
            {
                guitarAbilityImage.sprite = guitarUnlockSprite;
                guitarUnlock = true;
            }

            UpdateGuitarTimer();

            if(WorldStatus.Instance.Phase >= 2)
            {
                if(drumUnlock == false)
                {
                    drumAbilityImage.sprite = drumUnlockSprite;
                    drumUnlock = true;
                }

                UpdateDrumTimer();

                if(WorldStatus.Instance.Phase == 3)
                {
                    if(fluteUnlock == false)
                    {
                        fluteAbilityImage.sprite = fluteUnlockSprite;
                        fluteUnlock = true;
                    }

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
