using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LightSettingsPlayer : MonoBehaviour
{
   
    [SerializeField] PostProcessVolume Volume;
    [SerializeField] PostProcessProfile Standard;
    [SerializeField] PostProcessProfile NightVision;
    [SerializeField] GameObject NightVisionImage;
    [SerializeField] GameObject Flashlight;

    private bool NightVisionActive = false;
    private bool FlashlightActive = false;
    void Start()
    {
        NightVisionImage.gameObject.SetActive(false);
        Flashlight.gameObject.SetActive(false);
    }
    
    void Update()
    {
       if (SaveScript.BatteryPower > 0.0f)
       {
       if (Input.GetKeyDown(KeyCode.N))
       {
           if (NightVisionActive == false)
           {
               Volume.profile = NightVision;
               NightVisionActive = true;
               NightVisionImage.gameObject.SetActive(true);
               SaveScript.NightVisionOn = true;
           }
           else
           {
               Volume.profile = Standard;
               NightVisionActive = false;
               NightVisionImage.gameObject.SetActive(false);
               SaveScript.NightVisionOn = false;                 
           }
       }
        if (Input.GetKeyDown(KeyCode.F))
       {
           if (FlashlightActive == false)
           {
               FlashlightActive = true;
               Flashlight.gameObject.SetActive(true);
               SaveScript.FlashlightOn = true;
           }
           else
           {
               FlashlightActive = false;
               Flashlight.gameObject.SetActive(false);
               SaveScript.FlashlightOn = false;
           }
       }
    } 
    if (SaveScript.BatteryPower <= 0.0f)
    {
        Volume.profile = Standard;
        NightVisionActive = false;
        NightVisionImage.gameObject.SetActive(false);
        SaveScript.NightVisionOn = false;

        FlashlightActive = false;
        Flashlight.gameObject.SetActive(false);
        SaveScript.FlashlightOn = false;   
    }
    }
}
