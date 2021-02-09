using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    private float turnSpeed = 100f;
    private float forwardSpeed = 20f;
    private float horizontalInput;
    private float verticalInput;

    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
               
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
