using UnityEngine;


//Created with ai

public class CursorController : MonoBehaviour
{
    void Start()
    {
        // Turn off mouse cursor visibility when game starts
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None; 
        }
    }
}
