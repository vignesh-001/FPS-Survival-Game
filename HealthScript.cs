using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthScript : MonoBehaviour
{
    [SerializeField] Text HealthText;
    [SerializeField] GameObject DeathPanel;
    
    void Start()
    {
      DeathPanel.gameObject.SetActive(false);
      HealthText.text = SaveScript.PlayerHealth + "%" ;  
    }

   void Update()
    {
      if (SaveScript.HealthChanged == true)
      {
          SaveScript.HealthChanged = false;
          HealthText.text = SaveScript.PlayerHealth + "%" ;  
      } 
      if (SaveScript.PlayerHealth <= 0f)
      {
        SaveScript.PlayerHealth = 0;
        DeathPanel.gameObject.SetActive(true);
      } 
    }
}
