using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPower : MonoBehaviour
{
    [SerializeField] Image BatteryUI;
    [SerializeField] float DrainTime = 15.0f;
    [SerializeField] float Power;
    
    void Update()
    {
        if (SaveScript.BatteryRefill == true)
        {
            SaveScript.BatteryRefill = false;
            BatteryUI.fillAmount = 1.0f;
            Power = BatteryUI.fillAmount;
            SaveScript.BatteryPower = Power;
        }
        if(SaveScript.NightVisionOn == true || SaveScript.FlashlightOn == true)
        {
            BatteryUI.fillAmount -= 1.0f / DrainTime * Time.deltaTime;
            Power = BatteryUI.fillAmount;
            SaveScript.BatteryPower = Power;
        } 
    }
}
