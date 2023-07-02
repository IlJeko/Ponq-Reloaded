using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackAndForth : MonoBehaviour
{

    public float speed = 5f; // Speed of the cylinder movement
    public float distance; // Distance the cylinder travels

    private Vector3 startPosition;
    private float currentDistance;

    void Start()
    {
        startPosition = transform.position;
        currentDistance = 0f;
        distance = transform.position.z - (-transform.position.z);
    }

    void Update()
    {

        Vector3 nextPosition = startPosition + new Vector3(0, 0, -1) * currentDistance;

        transform.position = nextPosition;

        currentDistance += speed * Time.deltaTime;

        if (currentDistance >= distance)
        {
            speed *= -1f;
            currentDistance = distance;
        }
        else if (currentDistance <= 0f)
        {
            speed *= -1f;
            currentDistance = 0f;
        }
    }
}
