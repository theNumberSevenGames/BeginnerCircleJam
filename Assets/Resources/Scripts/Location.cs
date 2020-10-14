using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    
    public string name;
    public Player player;

    public float searchRNGMinimum;

    public float searchRNGMaximum;

    public string primaryResource;
    public int primaryStock;
    public int primaryStockRefill;
    public int primaryBaseFindRate;
    public GameObject rareResource;
    public int rareStock;
    public int rareStockRefill;
    public System.Random r1;
    void Start()
    {
        r1 = new System.Random();
    }

    // Update is called once per frame
    void Update()
    {
        search();
    }

    public void search()
    {
        float searchRNG = ((float)r1.NextDouble()) * (searchRNGMaximum - searchRNGMinimum) + searchRNGMinimum;
        int amountFound = Mathf.FloorToInt(primaryBaseFindRate * (1 + (player.stamina / 10)) * searchRNG);

        if(amountFound > 0)
        {
            player.addResources(primaryResource, amountFound);
        }

        if(player.stamina > 0)
        {
            player.reduceStamina(1);       
        }
    }
    public void restock()
    {
        primaryStock += primaryStockRefill;
    }
}
