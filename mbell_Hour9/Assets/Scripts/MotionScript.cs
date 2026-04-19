using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") / 10;
        float moveY = Input.GetAxis("Vertical") / 10;
        Vector3 movement = new Vector3(moveX, moveY, 0f);

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
