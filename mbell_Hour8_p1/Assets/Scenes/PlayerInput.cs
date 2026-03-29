using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.XR; // remove if unused

public class PlayerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        if (hVal != 0f)
        {
            Debug.Log("Horizontal movement selected: " + hVal);
        }

        if (vVal != 0f)
        {
            Debug.Log("Vertical movement selected: " + vVal);
        }

        if (Input.GetKey(KeyCode.M))
        {
            Debug.Log("The 'M' key is pressed down");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0)) // or KeyCode.Keypad0
        {
            Debug.Log("The '0' key was pressed");
        }
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
        {
            Debug.Log("Mouse X movement selected: " + mxVal);
        }
        if (myVal != 0) 
        {
            Debug.Log("Mouse Y movement selected: " + myVal);
        }
    
    
    
    }
}
