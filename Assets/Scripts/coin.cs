using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When the tank comes into contact with the coin, it causes the coin to disappear and be collected.
public class coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "tank")
        {
            coinText.coinAmount += 1;
            Destroy(gameObject);
        }
    }
}