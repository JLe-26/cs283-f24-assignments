using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlythroughCam : MonoBehaviour
{

    public float speed = 75.0f; // camera speed
    private Vector3 lastMouse = new Vector3(255, 255, 255); // center of the screen
    public float deltaX; // mouse x movement
    public float deltaY; // mouse y movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // WASD movement
         Vector3 dir = new Vector3(); 
         if(Input.GetKey(KeyCode.W))
         {
            dir.z += 1.0f; // camera will move forward
         }
        if(Input.GetKey(KeyCode.A))
         {
            dir.x += 1.0f; // camera will move right
         }
         if(Input.GetKey(KeyCode.S))
         {
            dir.z -= 1.0f; // camera will move backward
         }
         if(Input.GetKey(KeyCode.D))
         {
            dir.x -= 1.0f; // camera will move left
         }
         dir.Normalize();

        transform.Translate(dir * speed * Time.deltaTime);
        
        // Mouse movement
        lastMouse = Input.mousePosition - lastMouse;
        
        // movement of x from mouse input will result in a rotation around the y-axis and vice-versa
        lastMouse = new Vector3(transform.eulerAngles.x - lastMouse.y, transform.eulerAngles.y + lastMouse.x, 0); // lastMouse.y is negative to 
        //account for inversion of the camera movement
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;
        
        deltaX = Input.GetAxis("Mouse X");
        deltaY = Input.GetAxis("Mouse Y");

    }
}
