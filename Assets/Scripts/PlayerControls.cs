using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 10.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputSpeed = 0f;
        inputSpeed = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
    }
}
