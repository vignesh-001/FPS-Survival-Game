using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottlePickup : MonoBehaviour
{
    [SerializeField] int BottleNumber;
    
    void Start()
    {
        StartCoroutine(CheckBottles());
    }

   IEnumerator CheckBottles()
   {
       yield return new WaitForSeconds(1);
       if (BottleNumber > SaveScript.BottlesLeft)
       {
           Destroy(gameObject);
       }
   }
}
