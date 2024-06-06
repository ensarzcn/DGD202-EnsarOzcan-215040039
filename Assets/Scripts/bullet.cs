using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//It provides bullet control, includes preventing the base from being destroyed when the bullet hits the base and writing the object the bullet hit to the console.

public class bullet : MonoBehaviour
{
    public GameObject effeect;
    private void OnCollisionEnter(Collision collision)
    {
        string colliderName = collision.collider.gameObject.name;
        Debug.Log("Çarpan obje adý: " + colliderName);
        if (collision.collider.gameObject.name != "taban")
        Destroy(collision.gameObject);
        
        Destroy(gameObject);

        
    }

    private void OnDestroy()
    {
        Instantiate(effeect, transform.position, transform.rotation);
        
    }
}
