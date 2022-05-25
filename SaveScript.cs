using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour
{
    public static int PlayerHealth = 100;
    public static bool HealthChanged = false;
    public static float BatteryPower = 1.0f;
    public static bool BatteryRefill = false;
    public static bool FlashlightOn = false;
    public static bool NightVisionOn = false;
    public static int Bottle = 0;
    public static int Battery = 0;
    public static bool Knife = false;
    public static bool Bat = false;
    public static bool Axe = false;
    public static bool Gun = false;
    public static bool Crossbow = false;
    public static bool CabinKey = false;
    public static bool HouseKey = false;
    public static bool RoomKey = false;
    public static int Bullet = 0;
    public static bool ArrowRefill = false;
    public static bool HaveKnife = false;
    public static bool HaveBat = false;
    public static bool HaveAxe = false;
    public static bool HaveGun = false;
    public static bool HaveCrossbow = false;
    public static int Bullets = 12;
    public static int Arrows = 6;
    public static bool NewGame = false;
    public static bool SavedGame = false;
    public static int BottlesLeft = 10;
    public static int AmmoLeft = 4;
    public static int BatteryLeft = 5;
    public static int ArrowLeft = 3;
    public static int Zombie1 = 1;
    public static int Zombie2 = 1;
    public static int Zombie3 = 1;
    public static int Zombie4 = 1;
    public static int Zombie5 = 1;
    public static int Zombie6 = 1;
    public static int Zombie7 = 1;
    public static int Zombie8 = 1;
    public static int Zombie9 = 1;
    public static int Zombie10 = 1;
    public static int Zombie11 = 1;
    public static int Zombie12 = 1;
    
    private void Start()
    {
        if (NewGame == true)
        {
            PlayerHealth = 100;
            HealthChanged = true;
            BatteryPower = 1.0f;
            BatteryRefill = false;
            FlashlightOn = false;
            NightVisionOn = false;
            Bottle = 0;
            Battery = 0;
            Knife = false;
            Bat = false;
            Axe = false;
            Gun = false;
            Crossbow = false;
            CabinKey = false;
            HouseKey = false;
            RoomKey = false;
            Bullet = 0;
            ArrowRefill = false;
            HaveKnife = false;
            HaveBat = false;
            HaveAxe = false;
            HaveGun = false;
            HaveCrossbow = false;
            Bullets = 12;
            Arrows = 6;
            NewGame = false;
            BottlesLeft = 10;
            AmmoLeft = 4;
            BatteryLeft = 5;
            ArrowLeft = 3;
            Zombie1 = 1;
            Zombie2 = 1;
            Zombie3 = 1;
            Zombie4 = 1;
            Zombie5 = 1;
            Zombie6 = 1;
            Zombie7 = 1;
            Zombie8 = 1;
            Zombie9 = 1;
            Zombie10 = 1;
            Zombie11 = 1;
            Zombie12 = 1;
        }

        if(SavedGame == true)
        {
            PlayerHealth = PlayerPrefs.GetInt("PlayerHealth");
            HealthChanged = true;
            BatteryPower = PlayerPrefs.GetFloat("BatteryPower");
            Bottle = PlayerPrefs.GetInt("BottleAmt");
            Battery = PlayerPrefs.GetInt("BatteryAmt");
            Bullet = PlayerPrefs.GetInt("BulletsClips");
            Bullets = PlayerPrefs.GetInt("BulletsAmt");
            Arrows = PlayerPrefs.GetInt("ArrowsAmt");
            BottlesLeft = PlayerPrefs.GetInt("BottleL");
            AmmoLeft = PlayerPrefs.GetInt("AmmoL");
            BatteryLeft = PlayerPrefs.GetInt("BatteryL");
            ArrowLeft = PlayerPrefs.GetInt("ArrowL");
            Zombie1 = PlayerPrefs.GetInt("Zombie1Alive");
            Zombie2 = PlayerPrefs.GetInt("Zombie2Alive");
            Zombie3 = PlayerPrefs.GetInt("Zombie3Alive");
            Zombie4 = PlayerPrefs.GetInt("Zombie4Alive");
            Zombie5 = PlayerPrefs.GetInt("Zombie5Alive");
            Zombie6 = PlayerPrefs.GetInt("Zombie6Alive");
            Zombie7 = PlayerPrefs.GetInt("Zombie7Alive");
            Zombie8 = PlayerPrefs.GetInt("Zombie8Alive");
            Zombie9 = PlayerPrefs.GetInt("Zombie9Alive");
            Zombie10 = PlayerPrefs.GetInt("Zombie10Alive");
            Zombie11 = PlayerPrefs.GetInt("Zombie11Alive");
            Zombie12 = PlayerPrefs.GetInt("Zombie12Alive");
            if (PlayerPrefs.GetInt("KnifeInv") == 1)
            {
                Knife = true;
            }
            if (PlayerPrefs.GetInt("BatInv") == 1)
            {
                Bat = true;
            }
            if (PlayerPrefs.GetInt("AxeInv") == 1)
            {
                Axe = true;
            }
            if (PlayerPrefs.GetInt("GunInv") == 1)
            {
                Gun = true;
            }
            if (PlayerPrefs.GetInt("CrosbowInv") == 1)
            {
                Crossbow = true;
            }
            if (PlayerPrefs.GetInt("CabinK") == 1)
            {
                CabinKey = true;
            }
            if (PlayerPrefs.GetInt("HouseK") == 1)
            {
                HouseKey = true;
            }
            if (PlayerPrefs.GetInt("RoomK") == 1)
            {
                RoomKey = true;
            }
            if (PlayerPrefs.GetInt("ArrowR") == 1)
            {
                ArrowRefill = true;
            }
            SavedGame = false;
        }
    }

}
