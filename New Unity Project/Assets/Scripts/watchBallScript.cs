using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchBallScript : MonoBehaviour
{
    public Vector3 cameraOffSetPosition = new Vector3(0,0.45f, -8);
    public Quaternion cameraOffSetRotation = new Quaternion(2, 0, 0,-100);
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Sphere");
        Debug.Log(ball,ball);
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = gameObject.GetComponent<Camera>();
        camera.transform.position = ball.transform.position + cameraOffSetPosition;
        camera.transform.rotation = cameraOffSetRotation;
    }
}
