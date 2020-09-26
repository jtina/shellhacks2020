using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;   //control speed of mouse default to 100

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //hide and lock cursor to center of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime = amount of time that has passed since the last update function was called
        //to rotate independent of framerate
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        playerBody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY; //increase flips rotation
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //so that we cannot overrotate
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
