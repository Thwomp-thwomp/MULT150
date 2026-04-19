using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewTriggerScript : MonoBehaviour
{
    
    void OnTriggerEnter(Collider Other)
    {
        print("Entered: " + gameObject.name);
        
    }
   

    void OnTriggerStay(Collider Other)
    {

        print("Inside: " + gameObject.name);
    }
    
    private void OnTriggerExit(Collider LTrigger)
    {
        print("Exited: " +  gameObject.name);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
