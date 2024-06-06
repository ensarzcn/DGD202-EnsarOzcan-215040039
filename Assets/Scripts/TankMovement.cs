using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//It allows tanks to move forward.

public class TankMovement : MonoBehaviour
{
    public float speed = 5f; 

    private Rigidbody rb;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        MoveForward();
    }

    void MoveForward()
    {
        Vector3 forwardMovement = -transform.forward * speed * Time.deltaTime; 
        rb.MovePosition(rb.position + forwardMovement);
    }
}
