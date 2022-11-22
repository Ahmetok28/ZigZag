using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform ballLocation;
    Vector3 distance;
    void Start()
    {
        distance = transform.position - ballLocation.position;
    }

    
    void FixedUpdate()
    {
        if (BallMove.ballIsDown==false)
        {
            transform.position = ballLocation.position + distance;
        }
        
    }
}
