using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows shooting with mouse button

public class laser : MonoBehaviour
{
 
    public GameObject mermiObj; 
    public Transform atesNoktasi; 
    public float mermiHizi = 10f; 
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AtesEt();
        }
    }

    private void AtesEt()
    {
        GameObject mermi = Instantiate(mermiObj, atesNoktasi.position, atesNoktasi.rotation);
        Rigidbody mermiRigidbody = mermi.GetComponent<Rigidbody>();

        mermiRigidbody.velocity = atesNoktasi.forward * mermiHizi;
    }
}
