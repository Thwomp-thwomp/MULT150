using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerHealth: MonoBehaviour
{
    int healthpoints = 3992;
    
    // Start is called before the first frame update
    void Start()
    {
        UsePotion(healthpoints);
        healthpoints = healthpoints + 400;
        Debug.Log("healthpoints: " + healthpoints);

        UsePotion(healthpoints);
        healthpoints = healthpoints + 400;
        Debug.Log("healthpoints: " + healthpoints);

        UsePotion(healthpoints);
        healthpoints = healthpoints + 400;
        Debug.Log("healthpoints: " + healthpoints);

        UsePotion(healthpoints);
        healthpoints = healthpoints + 400;
        Debug.Log("healthpoints: " + healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        health = health + 400;
             return health;
    }

    




}

