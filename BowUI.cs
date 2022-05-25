using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BowUI : MonoBehaviour
{
    [SerializeField] Text BowAmt;
  
    void Start()
    {
        BowAmt.text = SaveScript.Arrows + ""; 
    }

    void Update()
    {
        BowAmt.text = SaveScript.Arrows + ""; 
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (SaveScript.Arrows > 0)
            {
                SaveScript.Arrows -= 1;
            }
        }
    }
}
