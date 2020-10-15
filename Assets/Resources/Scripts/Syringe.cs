using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syringe : Item
{
    
    void Start()
    {
        player.addItem(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void use()
    {
        player.restoreStamina(player.baseStamina);
    }
}
