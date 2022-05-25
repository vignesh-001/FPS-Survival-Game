using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickUp : MonoBehaviour
{
    [SerializeField] int BatteryNumber;
    
    void Start()
    {
        StartCoroutine(CheckBattery());
    }

   IEnumerator CheckBattery()
   {
       yield return new WaitForSeconds(1);
       if (BatteryNumber > SaveScript.BatteryLeft)
       {
           Destroy(gameObject);
       }
   }
}
