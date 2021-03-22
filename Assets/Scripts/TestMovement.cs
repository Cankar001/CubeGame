using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
    {
    public float moveSpeed = 30f;
	
	void Update ()
        {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) && Input.GetKey(KeyCode.LeftShift))
            {
            moveSpeed = 40f;
            }
        else
            {
            moveSpeed = 30f;
            }
        if (Input.GetKey(KeyCode.Space))
            {
            transform.SetPositionAndRotation(new Vector3(0f, 0.5f, 0f), new Quaternion());
            }

        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
	    }
    }
