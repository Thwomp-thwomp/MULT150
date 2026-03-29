using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Adjustied these values in the Inspector for speed
    public float moveSpeed = 10f;

    void Update()
    {
        // Get mouse input axes
        float mouseX = Input.GetAxis("Mouse X");  // Left/right mouse movement
        float mouseY = Input.GetAxis("Mouse Y");  // Up/down mouse movement

        // Translate the camera:
        // Mouse X → move left/right (along world X axis)
        // Mouse Y → move up/down (along world Y axis)
        // multiply by moveSpeed and Time.deltaTime for smooth movemnt per second instaed of per frame
        transform.Translate(new Vector3(mouseX * moveSpeed * Time.deltaTime, mouseY * moveSpeed * Time.deltaTime, 0f));


    }
}