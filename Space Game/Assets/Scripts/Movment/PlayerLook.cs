using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform PlayerBody;

    float xRotation = 0f;

    bool invOpen = false;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }



    void Update()
    {
        if (invOpen == false)

        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90, 90);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            PlayerBody.Rotate(Vector3.up * mouseX);
        }
    
            if (invOpen == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }    

            if (invOpen == true && Input.GetKeyDown(KeyCode.Escape))
        {
            invOpen = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

            if (invOpen == false && Input.GetKeyDown(KeyCode.E))
        {
            invOpen = true;
        }
    
    }
}
