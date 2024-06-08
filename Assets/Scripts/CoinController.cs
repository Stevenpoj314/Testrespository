using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin collected");

        Destroy(gameObject);
    }
   
}
