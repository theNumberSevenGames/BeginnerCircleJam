using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threat : MonoBehaviour
{

    public int powerLevel;
    public int powerLevelGrowth;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("gitTesting");
    }

    public void increasePower()
    {
        powerLevel += powerLevelGrowth;
    }
}
