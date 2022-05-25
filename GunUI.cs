using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunUI : MonoBehaviour
{
    [SerializeField] Text BulletAmt;
    
    void Start()
    {
        BulletAmt.text = SaveScript.Bullets + ""; 
    }

    void Update()
    {
        BulletAmt.text = SaveScript.Bullets + ""; 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (SaveScript.Bullets > 0)
            {
                SaveScript.Bullets -= 1;
                
            }
        }
    }
}
