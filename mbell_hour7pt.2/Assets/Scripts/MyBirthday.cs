using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        int DOB = 26;

        for (int day = 1; day <= 31; day++)
        {
            if (day == DOB)
            {
                Debug.Log("Its my birthday!");
            }
            else
            {
                Debug.Log(day);
            }
        }
    }

    void Update()
    {

    }
}
