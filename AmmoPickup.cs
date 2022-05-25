using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    [SerializeField] int AmmoNumber;
    
    void Start()
    {
        StartCoroutine(CheckAmmo());
    }

   IEnumerator CheckAmmo()
   {
       yield return new WaitForSeconds(1);
       if (AmmoNumber > SaveScript.AmmoLeft)
       {
           Destroy(gameObject);
       }
   }
}
