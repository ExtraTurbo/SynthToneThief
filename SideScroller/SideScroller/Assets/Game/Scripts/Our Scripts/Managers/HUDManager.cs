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
    private Text guitarKeybindText;

    [SerializeField]
    private Text guitarCooldownText;
    [SerializeField]
    private Slider guitarCooldownSlider;

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
    private Text drumKeybindText;

    [SerializeField]
    private Text drumCooldownText;
    [SerializeField]
    private Slider drumCooldownSlider;

    [SerializeField]
    private Slider drumDurationSlider;
    [SerializeField]
    private Image durationSliderFill;

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

    private float shieldDuration;
    public float ShieldDuration
    {
        set { shieldDuration = value; }
        get { return shieldDuration; }
    }

    private float currentShieldDuration;
    public float CurrentShieldDuration
    {
        set { currentShieldDuration = value; }
    }

    private bool drumUnlock;

    // FLUTE VALUES //
    [SerializeField]
    private Text fluteKeybindText;

    [SerializeField]
    private Text fluteCooldownText;
    [SerializeField]
    private Slider fluteCooldownSlider;

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

        currentGuitarCooldown = 0.0f;
        currentDrumCooldown = 0.0f;
        currentShieldDuration = 0.0f;
        currentFluteCooldown = 0.0f;

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
                guitarKeybindText.gameObject.SetActive(true);
                guitarCooldownSlider.gameObject.SetActive(true);
                guitarUnlock = true;
            }

            UpdateGuitarTimer();

            if(WorldStatus.Instance.Phase >= 2)
            {
                if(drumUnlock == false)
                {
                    drumAbilityImage.sprite = drumUnlockSprite;
                    drumKeybindText.gameObject.SetActive(true);
                    drumCooldownSlider.gameObject.SetActive(true);
                    drumDurationSlider.gameObject.SetActive(true);
                    drumUnlock = true;
                }

                UpdateDrumTimer();

                if(WorldStatus.Instance.Phase == 3)
                {
                    if(fluteUnlock == false)
                    {
                        fluteAbilityImage.sprite = fluteUnlockSprite;
                        fluteKeybindText.gameObject.SetActive(true);
                        fluteCooldownSlider.gameObject.SetActive(true);
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
                guitarCooldownSlider.value = 1.0f - (currentGuitarCooldown / guitarCooldown);
                guitarCooldownText.text = currentGuitarCooldown.ToString("0.0");
            }
            else
            {
                guitarCooldownSlider.value = 1.0f;
                guitarCooldownText.text = "";
            }
        }
        else
        {
            guitarCooldownSlider.value = 1.0f;
            guitarCooldownText.text = "";
        }
    }

    private void UpdateDrumTimer()
    {
        currentDrumCooldown = Mathf.Clamp(currentDrumCooldown, 0.0f, drumCooldown);
        currentShieldDuration = Mathf.Clamp(currentShieldDuration, 0.0f, shieldDuration);

        if (currentDrumCooldown != 0)
        {
            currentDrumCooldown -= Time.deltaTime;
            currentDrumCooldown = Mathf.Clamp(currentDrumCooldown, 0.0f, drumCooldown);

            if (currentDrumCooldown != 0)
            {
                drumCooldownSlider.value = 1.0f - (currentDrumCooldown / drumCooldown);
                drumCooldownText.text = currentDrumCooldown.ToString("0.0");
            }
            else
            {
                drumCooldownSlider.value = 1.0f;
                drumCooldownText.text = "";
            }
        }
        else
        {
            drumCooldownSlider.value = 1.0f;
            drumCooldownText.text = "";
        }

        if (currentShieldDuration != 0)
        {
            durationSliderFill.gameObject.SetActive(true);

            currentShieldDuration -= Time.deltaTime;
            currentShieldDuration = Mathf.Clamp(currentShieldDuration, 0.0f, shieldDuration);

            if (currentShieldDuration != 0)
            {
                drumDurationSlider.value = currentShieldDuration / shieldDuration;
            }
            else
            {
                durationSliderFill.gameObject.SetActive(false);
            }
        }
        else
        {
            durationSliderFill.gameObject.SetActive(false);
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
                fluteCooldownSlider.value = 1.0f - (currentFluteCooldown / fluteCooldown);
                fluteCooldownText.text = currentFluteCooldown.ToString("0.0");
            }
            else
            {
                fluteCooldownSlider.value = 1.0f;
                fluteCooldownText.text = "";
            }
        }
        else
        {
            fluteCooldownSlider.value = 1.0f;
            fluteCooldownText.text = "";
        }
    }
}
