using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
    public int EnemyHealth = 100;
    public bool HasDied = false;
    private Animator Anim; 
    [SerializeField] GameObject BloodSplatBat;
    [SerializeField] GameObject BloodSplatAxe;
    [SerializeField] GameObject BloodSplatKnife;
    
    void Start()
    {
        Anim = GetComponentInParent<Animator>();
        BloodSplatBat.gameObject.SetActive(false);
        BloodSplatAxe.gameObject.SetActive(false);
        BloodSplatKnife.gameObject.SetActive(false);
    }

    void Update()
    {
        if (EnemyHealth <= 0)
        {
            if (HasDied == false)
            {
                Anim.SetTrigger("Death");
                HasDied = true;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PKnife"))
        {
            EnemyHealth -= 10;
            BloodSplatKnife.gameObject.SetActive(true);
        }

         if (other.gameObject.CompareTag("PAxe"))
        {
            EnemyHealth -= 15;
            BloodSplatAxe.gameObject.SetActive(true);
        }

         if (other.gameObject.CompareTag("PBat"))
        {
            EnemyHealth -= 20;
            BloodSplatBat.gameObject.SetActive(true);
        }

        if (other.gameObject.CompareTag("PCrossbow"))
        {
            EnemyHealth -= 50;
            Destroy(other.gameObject, 0.05f);
        }
        
    } 
    
}
