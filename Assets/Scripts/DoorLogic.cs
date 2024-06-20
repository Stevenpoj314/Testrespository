using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLogic : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter(Collider Player)
    {
        Debug.Log("Press space to open");
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyUp(KeyCode.Space) && LevelScript.instance.HasFirstKey)
        {
            Destroy(Door);
        }

        else
        {
            Debug.Log("You don't have a key");
        }
    }
}
