using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Calculates the number of coins collected

public class coinText : MonoBehaviour
{
    Text text;
    public static int coinAmount;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
    }
}


