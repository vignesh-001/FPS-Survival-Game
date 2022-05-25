using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject InventoryMenu;
   
    private bool InventoryActive = false;
    private bool OptionsActive = false; 

    [SerializeField] GameObject PlayerArms;
    [SerializeField] GameObject Knife;
    [SerializeField] GameObject Bat;
    [SerializeField] GameObject Axe;
    [SerializeField] GameObject Crossbow;
    [SerializeField] GameObject Gun;
    
    [SerializeField] GameObject GunUI;
    [SerializeField] GameObject BulletAmt;

    [SerializeField] GameObject BowUI;
    [SerializeField] GameObject BowAmt;
    
    [SerializeField] GameObject OptionsMenu;
    
    [SerializeField] GameObject BottleImage1;
    [SerializeField] GameObject BottleButton1;

    [SerializeField] GameObject BottleImage2;
    [SerializeField] GameObject BottleButton2;

    [SerializeField] GameObject BottleImage3;
    [SerializeField] GameObject BottleButton3;

    
    [SerializeField] GameObject BatteryImage1;
    [SerializeField] GameObject BatteryButton1;

    [SerializeField] GameObject BatteryImage2;
    [SerializeField] GameObject BatteryButton2;
    
    [SerializeField] GameObject BatteryImage3;
    [SerializeField] GameObject BatteryButton3;

    [SerializeField] GameObject KnifeImage;
    [SerializeField] GameObject KnifeButton;

    [SerializeField] GameObject BatImage;
    [SerializeField] GameObject BatButton;

    [SerializeField] GameObject AxeImage;
    [SerializeField] GameObject AxeButton;

    [SerializeField] GameObject GunImage;
    [SerializeField] GameObject GunButton;

    [SerializeField] GameObject CrossbowImage;
    [SerializeField] GameObject CrossbowButton;

    [SerializeField] GameObject CabinKey;
    [SerializeField] GameObject HouseKey;
    [SerializeField] GameObject RoomKey;

    [SerializeField] GameObject BulletImage1;
    [SerializeField] GameObject BulletButton1;

    [SerializeField] GameObject BulletImage2;
    [SerializeField] GameObject BulletButton2;

    [SerializeField] GameObject ArrowImage;
    [SerializeField] GameObject ArrowButton;
    
    
    void Start()
    {
        InventoryMenu.gameObject.SetActive(false);

        
        
        GunUI.gameObject.SetActive(false);
        BulletAmt.gameObject.SetActive(false);

        BowUI.gameObject.SetActive(false);
        BowAmt.gameObject.SetActive(false);

        OptionsMenu.gameObject.SetActive(false);

        Cursor.visible = false;

        Time.timeScale = 1;  

        BottleImage1.gameObject.SetActive(false);
        BottleButton1.gameObject.SetActive(false);

        BottleImage2.gameObject.SetActive(false);
        BottleButton2.gameObject.SetActive(false);

        BottleImage3.gameObject.SetActive(false);
        BottleButton3.gameObject.SetActive(false);


        BatteryImage1.gameObject.SetActive(false);
        BatteryButton1.gameObject.SetActive(false);

        BatteryImage2.gameObject.SetActive(false);
        BatteryButton2.gameObject.SetActive(false);

        BatteryImage3.gameObject.SetActive(false);
        BatteryButton3.gameObject.SetActive(false);

        KnifeImage.gameObject.SetActive(false);
        KnifeButton.gameObject.SetActive(false);

        BatImage.gameObject.SetActive(false);
        BatButton.gameObject.SetActive(false);

        AxeImage.gameObject.SetActive(false);
        AxeButton.gameObject.SetActive(false);

        GunImage.gameObject.SetActive(false);
        GunButton.gameObject.SetActive(false);

        CrossbowImage.gameObject.SetActive(false);
        CrossbowButton.gameObject.SetActive(false);

        CabinKey.gameObject.SetActive(false);
        HouseKey.gameObject.SetActive(false);
        RoomKey.gameObject.SetActive(false);

        BulletImage1.gameObject.SetActive(false);
        BulletButton1.gameObject.SetActive(false);

        BulletImage2.gameObject.SetActive(false);
        BulletButton2.gameObject.SetActive(false);

        ArrowImage.gameObject.SetActive(false);
        ArrowButton.gameObject.SetActive(false);

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            if (OptionsActive == false)
            {
                OptionsMenu.gameObject.SetActive(true);
                OptionsActive = true;
            }
            else if (OptionsActive == true)
            {
                OptionsMenu.gameObject.SetActive(false);
                Cursor.visible = false;
                Time.timeScale = 1;
                OptionsActive = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
       {
           if (InventoryActive == false)
           {
               
               InventoryMenu.gameObject.SetActive(true);
               InventoryActive = true;
               Time.timeScale = 0f;
               Cursor.visible = true;
               
               SaveScript.HaveKnife = false;
               SaveScript.HaveBat = false;
               SaveScript.HaveAxe = false;
               SaveScript.HaveGun = false;
               SaveScript.HaveCrossbow = false;

               GunUI.gameObject.SetActive(false);
               BulletAmt.gameObject.SetActive(false);

               BowUI.gameObject.SetActive(false);
               BowAmt.gameObject.SetActive(false);
               
           }
           else if (InventoryActive == true)
           {
               InventoryMenu.gameObject.SetActive(false);
               InventoryActive = false;
               Time.timeScale = 1f;
               Cursor.visible = false;
           }
        }
        
        CheckInventory();

        CheckWeapons();

        CheckKeys();

        CheckAmmo();   
    }

    void CheckInventory()
    {
        if(SaveScript.Bottle == 0)
        {
            BottleImage1.gameObject.SetActive(false);
            BottleButton1.gameObject.SetActive(false);

            BottleImage2.gameObject.SetActive(false);
            BottleButton2.gameObject.SetActive(false);

            BottleImage3.gameObject.SetActive(false);
            BottleButton3.gameObject.SetActive(false);
        }

        if(SaveScript.Bottle == 1)
        {
            BottleImage1.gameObject.SetActive(true);
            BottleButton1.gameObject.SetActive(true);

            BottleImage2.gameObject.SetActive(false);
            BottleButton2.gameObject.SetActive(false);

            BottleImage3.gameObject.SetActive(false);
            BottleButton3.gameObject.SetActive(false);
        }

        if(SaveScript.Bottle == 2)
        {
            BottleImage1.gameObject.SetActive(true);
            BottleButton1.gameObject.SetActive(false);

            BottleImage2.gameObject.SetActive(true);
            BottleButton2.gameObject.SetActive(true);

            BottleImage3.gameObject.SetActive(false);
            BottleButton3.gameObject.SetActive(false);
        }

        if(SaveScript.Bottle == 3)
        {
            BottleImage1.gameObject.SetActive(true);
            BottleButton1.gameObject.SetActive(false);

            BottleImage2.gameObject.SetActive(true);
            BottleButton2.gameObject.SetActive(false);

            BottleImage3.gameObject.SetActive(true);
            BottleButton3.gameObject.SetActive(true);
        }

        if(SaveScript.Battery == 0)
        {
            BatteryImage1.gameObject.SetActive(false);
            BatteryButton1.gameObject.SetActive(false);       

            BatteryImage2.gameObject.SetActive(false);
            BatteryButton2.gameObject.SetActive(false);

            BatteryImage3.gameObject.SetActive(false);
            BatteryButton3.gameObject.SetActive(false);
        }

        if(SaveScript.Battery == 1)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(true);       

            BatteryImage2.gameObject.SetActive(false);
            BatteryButton2.gameObject.SetActive(false);

            BatteryImage3.gameObject.SetActive(false);
            BatteryButton3.gameObject.SetActive(false);
        }

        if(SaveScript.Battery == 2)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(false);       

            BatteryImage2.gameObject.SetActive(true);
            BatteryButton2.gameObject.SetActive(true);

            BatteryImage3.gameObject.SetActive(false);
            BatteryButton3.gameObject.SetActive(false);
        }

        if(SaveScript.Battery == 3)
        {
            BatteryImage1.gameObject.SetActive(true);
            BatteryButton1.gameObject.SetActive(false);      

            BatteryImage2.gameObject.SetActive(true);
            BatteryButton2.gameObject.SetActive(false);

            BatteryImage3.gameObject.SetActive(true);
            BatteryButton3.gameObject.SetActive(true);
        }
    }

    void CheckWeapons()
    {
        if (SaveScript.Knife == true)
        {
           KnifeImage.gameObject.SetActive(true);
           KnifeButton.gameObject.SetActive(true); 
        }
        
        if (SaveScript.Bat == true)
        {
           BatImage.gameObject.SetActive(true);
           BatButton.gameObject.SetActive(true); 
        }
        
        if (SaveScript.Axe == true)
        {
           AxeImage.gameObject.SetActive(true);
           AxeButton.gameObject.SetActive(true); 
        }
        
        if (SaveScript.Gun == true)
        {
           GunImage.gameObject.SetActive(true);
           GunButton.gameObject.SetActive(true); 
        }
        
        if (SaveScript.Crossbow == true)
        {
           CrossbowImage.gameObject.SetActive(true);
           CrossbowButton.gameObject.SetActive(true); 
        }
        
    }

    void CheckKeys()
    {
        if (SaveScript.CabinKey == true)
        {
            CabinKey.gameObject.SetActive(true);
        }
        if (SaveScript.HouseKey == true)
        {
            HouseKey.gameObject.SetActive(true);
        }
        if (SaveScript.RoomKey == true)
        {
            RoomKey.gameObject.SetActive(true);
        }
    }

    void CheckAmmo()
    {
        if (SaveScript.Bullet == 0)
        {
            BulletImage1.gameObject.SetActive(false);
            BulletButton1.gameObject.SetActive(false); 

            BulletImage2.gameObject.SetActive(false);
            BulletButton2.gameObject.SetActive(false);
        }
        
        if (SaveScript.Bullet == 1)
        {
            BulletImage1.gameObject.SetActive(true);
            BulletButton1.gameObject.SetActive(true); 

            BulletImage2.gameObject.SetActive(false);
            BulletButton2.gameObject.SetActive(false);
        }
        
        if (SaveScript.Bullet == 2)
        {
            BulletImage1.gameObject.SetActive(true);
            BulletButton1.gameObject.SetActive(false); 

            BulletImage2.gameObject.SetActive(true);
            BulletButton2.gameObject.SetActive(true);
        }

        if (SaveScript.ArrowRefill == false)
        {
            ArrowImage.gameObject.SetActive(false);
            ArrowButton.gameObject.SetActive(false);
        }
        
        if (SaveScript.ArrowRefill == true)
        {
            ArrowImage.gameObject.SetActive(true);
            ArrowButton.gameObject.SetActive(true);
        }
    }

    public void HealthUpdate()
    {
        if (SaveScript.PlayerHealth < 100)
        {
            SaveScript.PlayerHealth += 10;
            SaveScript.HealthChanged = true;
            SaveScript.Bottle -= 1;  
        }
        
        if (SaveScript.PlayerHealth > 100)
        {
            SaveScript.PlayerHealth = 100;
        }
    }

    public void BatteryUpdate()
    {
        SaveScript.BatteryRefill = true;
        SaveScript.Battery -= 1;
    }

    public void AssignKnife()
    {
        PlayerArms.gameObject.SetActive(true);
        Knife.gameObject.SetActive(true);
        SaveScript.HaveKnife = true;
        SaveScript.HaveBat = false;
        SaveScript.HaveAxe = false;
    }

    public void AssignBat()
    {
        PlayerArms.gameObject.SetActive(true);
        Bat.gameObject.SetActive(true);
        SaveScript.HaveKnife = false;
        SaveScript.HaveBat = true;
        SaveScript.HaveAxe = false;
    }

     public void AssignAxe()
    {
        PlayerArms.gameObject.SetActive(true);
        Axe.gameObject.SetActive(true);
        SaveScript.HaveKnife = false;
        SaveScript.HaveBat = false;
        SaveScript.HaveAxe = true;
    }

    public void AssignCrossbow()
    {
        PlayerArms.gameObject.SetActive(true);
        Crossbow.gameObject.SetActive(true);
        SaveScript.HaveGun = false;
        SaveScript.HaveKnife = false;
        SaveScript.HaveBat = false;
        SaveScript.HaveAxe = false;
        SaveScript.HaveCrossbow = true;
        BowUI.gameObject.SetActive(true);
        BowAmt.gameObject.SetActive(true);
    }

    public void AssignGun()
    {
        PlayerArms.gameObject.SetActive(true);
        Gun.gameObject.SetActive(true);
        SaveScript.HaveGun = true;
        SaveScript.HaveKnife = false;
        SaveScript.HaveBat = false;
        SaveScript.HaveAxe = false;
        GunUI.gameObject.SetActive(true);
        BulletAmt.gameObject.SetActive(true);
    }

    public void WeaponOff()
    {
        Knife.gameObject.SetActive(false);
        Bat.gameObject.SetActive(false);
        Axe.gameObject.SetActive(false);
        Crossbow.gameObject.SetActive(false);
        Gun.gameObject.SetActive(false); 
    }

    public void AmmoRefill()
    {
        GunUI.gameObject.SetActive(true);
        BulletAmt.gameObject.SetActive(true);
        SaveScript.Bullet -= 1;
        SaveScript.Bullets += 12;
        if (SaveScript.Bullets > 12)
        {
            SaveScript.Bullets = 12; 
        }
    }

    public void BowRefill()
    {
        BowUI.gameObject.SetActive(true);
        BowAmt.gameObject.SetActive(true);
        SaveScript.ArrowRefill = false;
        SaveScript.Arrows += 6;
        if (SaveScript.Arrows > 6)
        {
            SaveScript.Arrows = 6;
        }
    }
}
