using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 10.0f;
    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 velocity = body.velocity;
        if (Input.GetKey(moveUp))
        {
            velocity.z = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            velocity.z = -speed;
        }
        else
        {
            velocity.z = 0;
        }
        body.velocity = velocity;
    }
}
