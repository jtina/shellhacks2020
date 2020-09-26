using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;//control speed of movement
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f; //radius of sphere we will be using to check
    public LayerMask groundMask; //control what objects this sphere should check for

    Vector3 velocity;
    bool isGrounded; //grounded or not

    // Update is called once per frame
    void Update()
    {
        //creates a tiny invisible sphere at this point with the radius specified and if it collides with anything in our ground mask,
        //then isGrounded is true
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //check 
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; 
        }

        //getting input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //consider as an arrow that points in the direction we want to move
        Vector3 move = transform.right * x + transform.forward * z;

        //function on character controller
        //time.deltaTime makes it framerate independent
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime); //physics of freefall

    }
}
