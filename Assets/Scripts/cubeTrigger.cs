using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTrigger : MonoBehaviour
{
    public GameObject squarePrefab;
    public Vector3 PositionObject;
    public GameObject[] coinGroup;
    public string[] text;

    public void Start()
    {
        
        //Debug.Log(coinGroup[1].name);
        Debug.Log(text[2]);
    }
    private void OnTriggerEnter(Collider player)
    {

        //Instantiate(squarePrefab, PositionObject, Quaternion.identity);
        Debug.Log("Player enter trigger");
    }

    private void OnTriggerExit(Collider player) 
    {
        Debug.Log("Player exit trigger");

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Player stay in trigger");

    }


}
