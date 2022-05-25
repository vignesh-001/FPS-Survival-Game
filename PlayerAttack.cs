using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator Anim;
    [SerializeField] GameObject Crosshair;
    [SerializeField] GameObject Pointer;
    
    void Start()
    {
        Anim = GetComponent<Animator>();
        Crosshair.gameObject.SetActive(false);
        Pointer.gameObject.SetActive(true);
    }

    void Update()
    {
        if (SaveScript.HaveKnife == true)
        {
           
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Anim.SetTrigger("KnifeLMB");
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Anim.SetTrigger("KnifeRMB");
            }
        }

        if (SaveScript.HaveBat == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Anim.SetTrigger("BatLMB");
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Anim.SetTrigger("BatRMB");
            }
        }

         if (SaveScript.HaveAxe == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Anim.SetTrigger("AxeLMB");
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Anim.SetTrigger("AxeRMB");
            }
        }

        if (SaveScript.HaveGun == true)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Crosshair.gameObject.SetActive(true);
                Pointer.gameObject.SetActive(false);
            }

            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                Crosshair.gameObject.SetActive(false);
                Pointer.gameObject.SetActive(true);
            }
        }

        if (SaveScript.HaveCrossbow == true)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                Crosshair.gameObject.SetActive(true);
                Pointer.gameObject.SetActive(false);
            }

            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                Crosshair.gameObject.SetActive(false);
                Pointer.gameObject.SetActive(true);
            }
        }
    }
}
