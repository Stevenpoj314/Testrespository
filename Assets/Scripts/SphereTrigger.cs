using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    public GameObject SpherePrefab;
    public Vector3 PositionObject;
    private void OnTriggerEnter(Collider player)
    {
        Instantiate(SpherePrefab,PositionObject,Quaternion.identity);
    }
}
