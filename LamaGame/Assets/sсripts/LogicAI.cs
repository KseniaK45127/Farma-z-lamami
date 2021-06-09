using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicAI : MonoBehaviour
{
    public float moveForce = 0f;
    private Rigidbody rbody;
    public Vector3 moveDirection;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        moveDirection = NextPoint();
    }
    void Update()
    {

        if (transform.localPosition != moveDirection)
        {
           // moveDirection = transform.TransformDirection(moveDirection);
            transform.position = Vector3.MoveTowards(transform.localPosition, moveDirection, Time.deltaTime * moveForce);
            transform.localRotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDirection), Time.deltaTime * 2);

        }
        else
        {
            moveDirection = NextPoint();
        }

    }
    Vector3 NextPoint()
    {
        System.Random random = new System.Random();
        Vector3 temp = new Vector3();

        int pointX = random.Next(-2450, 2450);
        int pointZ = random.Next(-2450, 2450);

        temp.Set(pointX, 0, pointZ);

        // Debug.Log(temp);
        return temp;

    }
}
