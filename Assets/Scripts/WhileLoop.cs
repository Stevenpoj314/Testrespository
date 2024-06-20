using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    public int[] digits;
    public void Start()
    {
        TestLoop();
    }
    private void TestLoop()
    {
        int myNum = 0;
        while (myNum < digits.Length)
        {
            Debug.Log(digits[myNum]);
            myNum++;
        }
    }
}
