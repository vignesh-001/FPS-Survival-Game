using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKilled : MonoBehaviour
{
    [SerializeField] int ZombieNumber;
   
    void Start()
    {
        if(ZombieNumber == 1)
        {
            SaveScript.Zombie1 = 0;
        }
        
        if(ZombieNumber == 2)
        {
            SaveScript.Zombie2 = 0;
        }
        
        if(ZombieNumber == 3)
        {
            SaveScript.Zombie3 = 0;
        }
        
        if(ZombieNumber == 4)
        {
            SaveScript.Zombie4 = 0;
        }
        
        if(ZombieNumber == 5)
        {
            SaveScript.Zombie5 = 0;
        }
        
        if(ZombieNumber == 6)
        {
            SaveScript.Zombie6 = 0;
        }

        if(ZombieNumber == 7)
        {
            SaveScript.Zombie7 = 0;
        }

         if(ZombieNumber == 8)
        {
            SaveScript.Zombie8 = 0;
        }

         if(ZombieNumber == 9)
        {
            SaveScript.Zombie9 = 0;
        }
        if(ZombieNumber == 10)
        {
            SaveScript.Zombie10 = 0;
        }
        if(ZombieNumber == 11)
        {
            SaveScript.Zombie11 = 0;
        }
    }
}
