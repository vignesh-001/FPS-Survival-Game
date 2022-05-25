using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShot : MonoBehaviour
{
    RaycastHit hit;
    
    void Update()
    {
        if (SaveScript.HaveGun == true)
        {
            if (Input.GetKey(KeyCode.Mouse1) && Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (Physics .Raycast(transform.position, transform.forward, out hit, 3000))
                {
                    if (SaveScript.Bullets > 0)
                    {
                         if (hit.transform.Find("Z_Body"))
                        {
                            hit.transform.gameObject.GetComponentInChildren<EnemyDamage>().EnemyHealth -= Random.Range(30 , 101);
                            hit.transform.gameObject.GetComponent<Animator>().SetTrigger("Death");
                        }
                    }
                }
            }
        }
    }
}
