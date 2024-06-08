using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTrigger : MonoBehaviour
{
    public GameObject circlePrefab;
    public Vector3 PositionObject;
    private void OnTriggerEnter(Collider player)
    {
        Instantiate(circlePrefab, PositionObject, Quaternion.identity);
    }
}
