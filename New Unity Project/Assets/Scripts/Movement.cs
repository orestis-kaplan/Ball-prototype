using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Movement : MonoBehaviour
{
    public float xForce = 2.0f;
    public float yForce = 2.0f;
    public float zForce = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is call ed once per frame
    void Update()
    {
        Rigidbody ball = GetComponent<Rigidbody>();

        float x = 0.0f;
        float y = 0.0f;
        float z = 0.0f;

        // Move right
        if (Input.GetKey(KeyCode.D))
            x = x + xForce;
        // Move left
        if (Input.GetKey(KeyCode.A))       
            x = x - xForce;                
        // Move forward
        if (Input.GetKey(KeyCode.W))        
            z = z + zForce;                
        // Move backward
        if (Input.GetKey(KeyCode.S))
            z = z - zForce;
        // Jump
        if (Input.GetKey(KeyCode.Space))
            y = yForce;


        ball.AddForce(x, y, z);
    }
}
