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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayEnd()
    {
        //THREAT FUCKS YOU UP

        //IF SURVIVE
        player.restoreStamina(baseStamina);
    }
}
