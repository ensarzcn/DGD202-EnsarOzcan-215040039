using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Script to control the camera with the mouse

public class cam : MonoBehaviour
{

    float xRot = 0.0f;
    float yRot = 0.0f;
    public float sens = 100.0f;
    public GameObject player,top;

    private void Start()
    {

    }



    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sens;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sens;
        xRot -= mouseY;
        yRot += mouseY;
        yRot = Mathf.Clamp(yRot, -10f, 20f);
        xRot = Mathf.Clamp(xRot, -10f, 30f);
        
        transform.localRotation = Quaternion.Euler(xRot, 180f, 0);
        player.transform.rotation *= Quaternion.Euler(0, mouseX, 0);
        top.transform.localRotation=Quaternion.Euler(yRot, 0, 0);
        top.transform.rotation *= Quaternion.Euler(mouseY, 0, 0);
    }
}
