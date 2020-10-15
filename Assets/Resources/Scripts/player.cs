using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
   public int stamina;
   public int baseStamina;
   public int metal;
   public int energy;
   public int fuel;

   public int baseDefense; 

   public List<Item> itemList = new List<Item>();
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(itemList[0]);
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

    public void decreaseDefense(int amount)
    {
        this.baseDefense -= amount;
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

    public void addItem(Item item)
    {
        itemList.Add(item);
    }
}
