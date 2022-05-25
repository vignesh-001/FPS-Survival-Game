using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float Distance = 4.0f;        
    [SerializeField] GameObject PickupMessage;
    [SerializeField] GameObject PlayerArms;
    [SerializeField] GameObject GameOverPanel;


    private float RayDistance;
    private bool CanSeePickup = false;

    void Start()
    {
        GameOverPanel.gameObject.SetActive(false);
        PickupMessage.gameObject.SetActive(false);
        PlayerArms.gameObject.SetActive(false);
        RayDistance = Distance;
    }

   void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, RayDistance))
        {
            if (hit.transform.tag == "Bottle")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if(SaveScript.Bottle < 3)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.BottlesLeft--;
                    SaveScript.Bottle += 1;
                    }
                }    
            }
            else if (hit.transform.tag == "Battery")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Battery < 3)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.BatteryLeft--;
                    SaveScript.Battery += 1;
                    }
                }    
            }
            else if (hit.transform.tag == "Bat")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Bat == false)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.Bat = true;
                    }
                }  
            }
            else if (hit.transform.tag == "Knife")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Knife == false)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.Knife = true;
                    }
                }  
            }
            else if (hit.transform.tag == "Axe")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Axe == false)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.Axe = true;
                    }
                }  
            }
            else if (hit.transform.tag == "Crossbow")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Crossbow == false)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.Crossbow = true;
                    }
                }  
            }
            else if (hit.transform.tag == "Gun")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Gun == false)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.Gun = true;
                    }
                }  
            }
            else if (hit.transform.tag == "CabinKey")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.CabinKey == false)
                   {
                    Destroy(hit.transform.gameObject);
                    //GameOverPanel.gameObject.SetActive(true);
                    SaveScript.CabinKey = true;
                    }
                }  
            }
            else if (hit.transform.tag == "HouseKey")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.HouseKey == false)
                   {
                    Destroy(hit.transform.gameObject);
                    //GameOverPanel.gameObject.SetActive(true);
                    SaveScript.HouseKey = true;
                    }
                }  
            }
            else if (hit.transform.tag == "RoomKey")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.RoomKey == false)
                   {
                    Destroy(hit.transform.gameObject);
                    GameOverPanel.gameObject.SetActive(true);
                    SaveScript.RoomKey = true;
                    }
                }  
            }
            else if (hit.transform.tag == "Ammo")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Bullet < 2)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.AmmoLeft--;
                    SaveScript.Bullet += 1;
                    }
                }  
            }
            else if (hit.transform.tag == "Arrow")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.ArrowRefill == false)
                   {
                    Destroy(hit.transform.gameObject);
                    SaveScript.ArrowLeft--;
                    SaveScript.ArrowRefill = true;
                    }
                }  
            }
            else if (hit.transform.tag == "Ammo")
            {
               CanSeePickup = true;
               if (Input.GetKeyDown(KeyCode.E))
               {
                   if (SaveScript.Bullet < 2)
                   {
                    Destroy(hit.transform.gameObject);
                    
                    SaveScript.Bullet =+ 1;
                    }
                }  
            }
            else
            {
                CanSeePickup = false;
            }
        }
        if (CanSeePickup == true)
        {
            PickupMessage.gameObject.SetActive(true);
            RayDistance = 1000f;
        }
        if (CanSeePickup == false)
        {
            PickupMessage.gameObject.SetActive(false);
            RayDistance = Distance;
        }
    }
}
