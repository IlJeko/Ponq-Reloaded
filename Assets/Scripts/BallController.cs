using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody body;

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
        transform.position = Vector3.zero;
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector3 vel = Vector3.zero;
            vel.x = body.velocity.x;
            vel.z = (body.velocity.z / 2) + (coll.collider.attachedRigidbody.velocity.z / 3);
            body.velocity = vel;
        }
    }

}
