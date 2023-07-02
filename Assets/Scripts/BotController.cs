using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    private GameObject ball;
    private Vector3 ballPos;
    public float moveSpeed = 8.0f;

    void FixedUpdate()
    {
        if (!ball)
        {
            ball = GameObject.FindGameObjectWithTag("Ball");
        }

        ballPos = ball.transform.localPosition;
        if (ballPos.z < transform.localPosition.z)
        {
            transform.localPosition += new Vector3(0, 0, -moveSpeed * Time.deltaTime);
        }
        if (ballPos.z > transform.localPosition.z)
        {
            transform.localPosition += new Vector3(0, 0, moveSpeed * Time.deltaTime);
        }
    }
}
