using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        {
            Debug.Log("Starting Health: " + health);
        }
        while (health > 0)
        {
            health = health - poisonDamage;
            

            Debug.Log("Health after poison damage " + ": " + health);
        }

        Debug.Log("Player has been unalived!");
    }

    void Update()
    {

    }
}