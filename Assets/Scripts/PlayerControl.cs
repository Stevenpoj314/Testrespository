using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public Rigidbody rb;

    public Vector3 speed; 
   
  

    private void Start()
    {

        
       

    }

    void Update()
    {
        speed.x = Input.GetAxis("Horizontal");

        speed.z = Input.GetAxis("Vertical");

        rb.velocity = speed; 

    }


}
