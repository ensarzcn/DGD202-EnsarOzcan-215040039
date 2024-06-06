using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Includes control of the tank
public class tank : MonoBehaviour
{

    public float turnSpeed = 0.5f;
    public float moveSpeed = 2f; 
    public float acceleration = 1f; 

    private float currentSpeed = 0f; 


    void Update()
    {
        if (Input.GetKey("r")){
            transform.position = new Vector3(-1.13900006f, 3.20000005f, 1.54799998f);
            transform.rotation = Quaternion.identity;
        }
        if (Input.GetKey("a"))
        {
            float targetAngle = transform.eulerAngles.y - 90f; 
            float currentAngle = Mathf.LerpAngle(transform.eulerAngles.y, targetAngle, turnSpeed * Time.deltaTime); 
            transform.eulerAngles = new Vector3(0, currentAngle, 0); 
        }
        else if (Input.GetKey("d"))
        {
            float targetAngle = transform.eulerAngles.y + 90f; 
            float currentAngle = Mathf.LerpAngle(transform.eulerAngles.y, targetAngle, turnSpeed * Time.deltaTime); 
            transform.eulerAngles = new Vector3(0, currentAngle, 0); 
        }

        if (Input.GetKey("s"))
        {
            currentSpeed += acceleration * Time.deltaTime; 
            currentSpeed = Mathf.Clamp(currentSpeed, 0f, moveSpeed); 

            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime); 
        }
        else if (Input.GetKey("w"))
        {
            currentSpeed -= acceleration * Time.deltaTime; 
            currentSpeed = Mathf.Clamp(currentSpeed, -moveSpeed, 0f); 

            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime); 
        }
        else
        {
            currentSpeed = 0f; 
        }


    }
}
