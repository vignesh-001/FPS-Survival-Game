using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    [SerializeField] GameObject Knife;
    [SerializeField] GameObject Bat;
    [SerializeField] GameObject Axe;
    [SerializeField] GameObject Gun;
    [SerializeField] GameObject Crossbow;
    // [SerializeField] GameObject CabinKey;
    // [SerializeField] GameObject HouseKey;
    //[SerializeField] GameObject RoomKey;
    [SerializeField] GameObject Zombie1;
    [SerializeField] GameObject Zombie2;
    [SerializeField] GameObject Zombie3;
    [SerializeField] GameObject Zombie4;
    [SerializeField] GameObject Zombie5;
    [SerializeField] GameObject Zombie6;
    [SerializeField] GameObject Zombie7;
    [SerializeField] GameObject Zombie8;
    [SerializeField] GameObject Zombie9;
    [SerializeField] GameObject Zombie10;
    [SerializeField] GameObject Zombie11;
    [SerializeField] GameObject Zombie12;
    
    void Start()
    {
        StartCoroutine(WaitToDestroy());
    }

    IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(1);
        if (SaveScript.Knife == true)
        {
            Destroy(Knife.gameObject);
        }
        if (SaveScript.Bat == true)
        {
            Destroy(Bat.gameObject);
        }
        if (SaveScript.Axe == true)
        {
            Destroy(Axe.gameObject);
        }
        if (SaveScript.Gun == true)
        {
            Destroy(Gun.gameObject);
        }
        if (SaveScript.Crossbow == true)
        {
            Destroy(Crossbow.gameObject);
        }
        // if (SaveScript.CabinKey == true)
        // {
        //     Destroy(CabinKey.gameObject);
        // }
        // if (SaveScript.HouseKey == true)
        // {
        //     Destroy(HouseKey.gameObject);
        // }
        // if (SaveScript.RoomKey == true)
        // {
        //     Destroy(RoomKey.gameObject);
        // }
        if(SaveScript.Zombie1 == 0)
        {
            Destroy(Zombie1.gameObject);
        }
         if(SaveScript.Zombie2 == 0)
        {
            Destroy(Zombie2.gameObject);
        }
         if(SaveScript.Zombie3 == 0)
        {
            Destroy(Zombie3.gameObject);
        }
         if(SaveScript.Zombie4 == 0)
        {
            Destroy(Zombie4.gameObject);
        }
         if(SaveScript.Zombie5 == 0)
        {
            Destroy(Zombie5.gameObject);
        }
         if(SaveScript.Zombie6 == 0)
        {
            Destroy(Zombie6.gameObject);
        }
        if(SaveScript.Zombie7 == 0)
        {
            Destroy(Zombie7.gameObject);
        }
        if(SaveScript.Zombie8 == 0)
        {
            Destroy(Zombie8.gameObject);
        }
        if(SaveScript.Zombie9 == 0)
        {
            Destroy(Zombie9.gameObject);
        }
        if(SaveScript.Zombie10 == 0)
        {
            Destroy(Zombie10.gameObject);
        }
        if(SaveScript.Zombie11 == 0)
        {
            Destroy(Zombie11.gameObject);
        }
         if(SaveScript.Zombie12 == 0)
        {
            Destroy(Zombie12.gameObject);
        }
    }
}
