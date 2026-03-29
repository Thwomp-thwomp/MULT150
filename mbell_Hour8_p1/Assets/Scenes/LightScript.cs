using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    private Light Lightbulb;
    // Start is called before the first frame update
    void Start()
    {
        Lightbulb = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Lightbulb.enabled = !Lightbulb.enabled;
        }
    
    
    
    
    
    }
}
