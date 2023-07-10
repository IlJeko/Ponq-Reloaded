using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody body;
    private float bounceForce = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Invoke("StartBall", 2);
    }

    void StartBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            body.AddForce(new Vector3(20, 0, -15));
        }
        else
        {
            body.AddForce(new Vector3(-20, 0, -15));
        }
    }

    void ResetBall()
    {
        body.velocity = Vector3.zero;
        transform.position = new Vector3(0, 0.375f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (body.velocity.magnitude > 25f)
            bounceForce = 1.0f;
        else
            bounceForce = 1.2f;
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 vel = Vector3.zero;
            vel.x = body.velocity.x;
            float dist = this.transform.position.z - GameObject.Find("Player Paddle").transform.position.z;
            body.velocity = new Vector3(vel.x * bounceForce, 0f, dist * 3f);
        }
        else if (collision.gameObject.CompareTag("Opponent"))
        {
            Vector3 vel = Vector3.zero;
            vel.x = body.velocity.x;
            float dist = this.transform.position.z - GameObject.Find("Opponent Paddle").transform.position.z;
            body.velocity = new Vector3(vel.x * bounceForce, 0f, dist * 3f);
        }
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Finish"))
        {
            GameManager.Score(coll.gameObject.name);
            ResetBall();
            Invoke("StartBall", 2);
        }
       
    }
}
