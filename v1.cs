using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script is attached to an empty player object

public class TwinEngineMovement : MonoBehaviour
{

    public float gravityAcceleration = -0.5f;
    public float enginePower = 0.7f;
    public float paddleSize = 3f;
    public Transform paddle;
    public Transform leftPivot;
    public Transform rightPivot;
    public GameObject leftFire;
    public GameObject rightFire;


    float angle;

    // Start is called before the first frame update
    void Start()
    {
        //Paddle size:
        paddle.transform.localScale = new Vector3(paddleSize, 1f, 1f);
        leftPivot.position = transform.position + new Vector3(-paddleSize/2, -0.5f, 0f);
        rightPivot.position = transform.position + new Vector3(paddleSize/2, -0.5f, 0f);

        angle = Mathf.Atan(enginePower/paddleSize) * Mathf.Rad2Deg;

    }

    // Update is called once per frame
    void Update()
    {
        bool leftMotorPressed = Input.GetKey("a");
        bool rightMotorPressed = Input.GetKey("d");
        
        if (leftMotorPressed && rightMotorPressed) 
        {
            //Move up
            Debug.Log("Moving forward!");
            transform.position += transform.up * enginePower * Time.deltaTime;
            leftFire.SetActive(true);
            rightFire.SetActive(true);

        }

        if (leftMotorPressed && !rightMotorPressed)
        {
            //Rotate around right pivot
            Debug.Log("Rotating around right pivot!");
            transform.RotateAround(rightPivot.transform.position, Vector3.back, angle * Time.deltaTime);
            leftFire.SetActive(true);
            rightFire.SetActive(false);

        }

        if (rightMotorPressed && !leftMotorPressed)
        {
            //Rotate around left pivot
            Debug.Log("Rotating around left pivot!");
            transform.RotateAround(leftPivot.transform.position, Vector3.forward, angle * Time.deltaTime);
            leftFire.SetActive(false);
            rightFire.SetActive(true);
        }

        if (!rightMotorPressed && !leftMotorPressed) 
        {
            leftFire.SetActive(false);
            rightFire.SetActive(false);
        }

        //Gravity
        transform.position = transform.position + new Vector3(0, gravityAcceleration * Time.deltaTime, 0);
        
    }
}
