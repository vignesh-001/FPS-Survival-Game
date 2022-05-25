using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] GameObject LoadButton;
    public int DataExists = 10;
    
    void Start()
    {
        if (LoadButton != null)
        {
            DataExists = PlayerPrefs.GetInt("PlayerHealth",0);
            LoadButton.gameObject.SetActive(false);
            if (DataExists > 0)
            {
                LoadButton.gameObject.SetActive(true);
            }
        }
    }
    
    public void LoadGameData()
    {
        SaveScript.SavedGame = true;
    }

    public void SaveGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("PlayerHealth" , SaveScript.PlayerHealth);
        PlayerPrefs.SetFloat("BatteryPower", SaveScript.BatteryPower);
        PlayerPrefs.SetInt("BottleAmt", SaveScript.Bottle);
        PlayerPrefs.SetInt("BatteryAmt",SaveScript.Battery);
        PlayerPrefs.SetInt("BulletsClips", SaveScript.Bullet);
        PlayerPrefs.SetInt("BulletsAmt",SaveScript.Bullets);
        PlayerPrefs.SetInt("ArrowsAmt",SaveScript.Arrows);
        PlayerPrefs.SetInt("BottleL",SaveScript.BottlesLeft);
        PlayerPrefs.SetInt("AmmoL",SaveScript.AmmoLeft);
        PlayerPrefs.SetInt("BatteryL",SaveScript.BatteryLeft);
        PlayerPrefs.SetInt("ArrowL",SaveScript.ArrowLeft);
        PlayerPrefs.SetInt("Zombie1Alive",SaveScript.Zombie1);
        PlayerPrefs.SetInt("Zombie2Alive",SaveScript.Zombie2);
        PlayerPrefs.SetInt("Zombie3Alive",SaveScript.Zombie3);
        PlayerPrefs.SetInt("Zombie4Alive",SaveScript.Zombie4);
        PlayerPrefs.SetInt("Zombie5Alive",SaveScript.Zombie5);
        PlayerPrefs.SetInt("Zombie6Alive",SaveScript.Zombie6);
        PlayerPrefs.SetInt("Zombie7Alive",SaveScript.Zombie7);
        PlayerPrefs.SetInt("Zombie8Alive",SaveScript.Zombie8);
        PlayerPrefs.SetInt("Zombie9Alive",SaveScript.Zombie9);
        PlayerPrefs.SetInt("Zombie10Alive",SaveScript.Zombie10);
        PlayerPrefs.SetInt("Zombie11Alive",SaveScript.Zombie11);
        PlayerPrefs.SetInt("Zombie12Alive",SaveScript.Zombie12);
        if (SaveScript.Knife == true)
        PlayerPrefs.SetInt("KnifeInv",1);
        if (SaveScript.Bat == true)
        PlayerPrefs.SetInt("BatInv",1);
        if (SaveScript.Axe == true)
        PlayerPrefs.SetInt("AxeInv",1);
        if (SaveScript.Gun == true)
        PlayerPrefs.SetInt("GunInv",1);
        if (SaveScript.Crossbow == true)
        PlayerPrefs.SetInt("CrossbowInv",1);
        if (SaveScript.CabinKey == true)
        PlayerPrefs.SetInt("CabinK",1);
        if (SaveScript.HouseKey == true)
        PlayerPrefs.SetInt("HouseK",1);
        if (SaveScript.RoomKey == true)
        PlayerPrefs.SetInt("RoomK",1);
        if(SaveScript.ArrowRefill == true)
        PlayerPrefs.SetInt("ArrowR",1);
    }
}
