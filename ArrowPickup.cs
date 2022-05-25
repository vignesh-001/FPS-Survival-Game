using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPickup : MonoBehaviour
{
    [SerializeField] int ArrowNumber;
    
    void Start()
    {
        StartCoroutine(CheckArrow());
    }

   IEnumerator CheckArrow()
   {
       yield return new WaitForSeconds(1);
       if (ArrowNumber > SaveScript.ArrowLeft)
       {
           Destroy(gameObject);
       }
   }
}
