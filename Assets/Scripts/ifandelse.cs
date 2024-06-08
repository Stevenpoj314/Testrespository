using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifandelse : MonoBehaviour
{
    public int value;

    void Start()

    {
        if (value % 2 == 0)

            Debug.Log("Even");

        else

            Debug.Log("Odd");
    }  

    void Update()
    {

    }
}