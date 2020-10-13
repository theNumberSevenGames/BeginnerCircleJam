using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
   public int stamina;
   public int metal;
   public int energy;
   public int fuel;

   public int baseDefense; 

   public List<GameObject> itemList = new List<GameObject>();
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restoreStamina(int amount)
    {
        this.stamina += amount;
    }

    public void reduceStamina(int amount)
    {
        this.stamina -= amount;
    }

    public void increaseDefense(int amount)
    {
        this.baseDefense += amount;
    }

    public void addResources(string type, int amount)
    {
        if(type == "Metal")
        {
            this.metal += amount;
        }
        else if(type == "Energy")
        {
            this.energy += amount;
        }
        else if(type == "Fuel")
        {
            this.fuel += amount;
        }
    }

    public void reduceResources(string type, int amount)
    {
        if(type == "Metal")
        {
            this.metal -= amount;
        }
        else if(type == "Energy")
        {
            this.energy -= amount;
        }
        else if(type == "Fuel")
        {
            this.fuel -= amount;
        }
    }
}
