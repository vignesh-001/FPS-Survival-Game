using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponDamage : MonoBehaviour
{
    [SerializeField] int WeaponDamage = 10;
    [SerializeField] Animator HurtAnim;
    private bool HitActive = false;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (HitActive == false)
            {
                
                HitActive = true;
                HurtAnim.SetTrigger("Hurt");
                SaveScript.PlayerHealth -= WeaponDamage;
                SaveScript.HealthChanged = true;
                ResetHit();
                StartCoroutine(ResetHit());
            }
        }
    }

     private void OnTriggerExit (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (HitActive == true)
            {
                HitActive = false;
            }
        }
    }

    IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f);
        if (HitActive == true)
        {
            HitActive = false;
        }
    }
}
