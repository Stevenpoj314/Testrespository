using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    public GameObject CubePrefab;
    public Vector3 PositionObject;


    private void OnTriggerEnter(Collider player)
    {
        Instantiate(CubePrefab, PositionObject, Quaternion.identity);
    }
}
