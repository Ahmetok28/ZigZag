using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    Vector3 direct;
    public float speed;
    public GroundSpawner GroundSpawnScript;
    public static bool ballIsDown;
    public float speedUp;
    void Start()
    {
        direct = Vector3.forward;
        ballIsDown = false;
    }

  
    void Update()
    {
        if (transform.position.y<=0.5)
        {
            ballIsDown = true;
        }
        if (ballIsDown==true)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (direct.x==0)
            {
                direct = Vector3.left;
            }
            else
            {
                direct = Vector3.forward;
            }
            speed += speedUp * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 move = direct * Time.deltaTime * speed;
        transform.position += move;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            GroundSpawnScript.Ground_Spawner();
            StartCoroutine(deleteGorund(collision.gameObject));
        }
    }

    IEnumerator deleteGorund(GameObject deletedGround)
    {
        yield return new WaitForSeconds(3f);
        Destroy(deletedGround);
    }
}
