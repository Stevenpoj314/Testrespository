using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscript : MonoBehaviour
   
{
    public GameObject cube;
    public GameObject[] cubeGroup;
 
    private void Start()
    {

        int space = 2;

        Vector3 newposition = Vector3.zero;
        for (int x = 0; x < 5; x++)
        {

            for (int y = 0; y < 5; y++)
            {

                for (int z = 0; z < 5; z++)
                {
                    GameObject spawnCube = Instantiate(cube);
                    newposition.x = space * x;
                    newposition.y = space * y;
                    newposition.z = space * z;
                    spawnCube.transform.position = newposition;
                    Debug.Log("Inner:" + z);
                    
                }

            }
          
        }


    }


}
