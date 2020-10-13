using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    
    public string name;
    public player player;

    public string primaryResource;
    public int primaryStock;
    public int primaryStockRate;
    public GameObject rareResource;
    public int rareStock;
    public int rareStockRate;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void search()
    {
        //move x resources from location to player
        //resourceFoundAmount * staminaCoef = amount moved

    }
    public void restock()
    {
        primaryStock += primaryStockRate;
    }
}
