using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public CharacterController controler;

    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 3f;
    public float sprintSpeed = 10f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velosity;  
    bool isGrounded;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velosity.y < 0)
        {
            velosity.y = -2f;
        }

        
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controler.Move(move * speed * Time.deltaTime);

            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velosity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded)
            {
                speed = sprintSpeed;
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed = 6;
            }

            if (isGrounded == false && Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed = 10;
            }

            velosity.y += gravity * Time.deltaTime;

            controler.Move(velosity * Time.deltaTime);
        
        }
}
