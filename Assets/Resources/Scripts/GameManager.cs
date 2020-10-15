using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;

    public Threat threat;
    
    public int baseStamina;
    void Start()
    {
        baseStamina = player.baseStamina;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayEnd()
    {
        //THREAT FUCKS YOU UP
        player.decreaseDefense(threat.powerLevel);

        if(player.baseDefense >= 0)
        {
            //TEXT DESCRIBING ACTION//
            player.restoreStamina(baseStamina);
            threat.increasePower();
        }
        else
        {
            //you die
        }

        
    }
}
