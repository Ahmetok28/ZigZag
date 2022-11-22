using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject lastGround;
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            Ground_Spawner();
            i++;
        }
    }


    void Update()
    {
        
    }

    public void Ground_Spawner()
    {
        Vector3 direct;
        if (Random.Range(0, 2) == 0)
        {
            direct = Vector3.left;
        }
        else
        {
            direct = Vector3.forward;
        }
        lastGround = Instantiate(lastGround, lastGround.transform.position + direct, lastGround.transform.rotation);

    }
}
