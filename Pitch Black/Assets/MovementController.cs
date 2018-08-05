using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    public Rigidbody body;
    public float movementSpeed = 1f;

    public GameObject above;
    int reversed;

	// Use this for initialization
	void Start () {
        Debug.Log(reversed);
        Debug.Log(above.transform.rotation);
		if(above.transform.rotation.y == 1.0)
        {
            reversed = -1;
        }
        else
        {
            reversed = 1;
        }
        Debug.Log(reversed);
	}
	
	// Update is called once per frame
	void Update () {
        GetInput();

	}

    void GetInput()
    {
        /*
        if (Input.GetKey("w"))
        {
            MovePlayer(0, 1);
        }

        if (Input.GetKey("s"))
        {
            MovePlayer(0, -1);
        }

        if (Input.GetKey("a"))
        {
            MovePlayer(-1, 0);
        }

        if (Input.GetKey("d"))
        {
            MovePlayer(1, 0);
        }
        */

        body.AddForce(0, 0, reversed * (Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime) , ForceMode.VelocityChange);
        body.AddForce( reversed * (Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime) , 0, 0, ForceMode.VelocityChange);



        /*

        if (Input.GetKey("a"))
        {
            body.AddForce(-(movementSpeed * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            body.AddForce((movementSpeed * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("w"))
        {
            body.AddForce(0, 0, (movementSpeed * Time.deltaTime), ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            body.AddForce(0, 0, -(movementSpeed * Time.deltaTime), ForceMode.VelocityChange);
        }

        */
    }

    void MovePlayer(int x, int z)
    {
        body.AddForce( x*(movementSpeed * Time.deltaTime) , 0 , z* (movementSpeed * Time.deltaTime) , ForceMode.VelocityChange);
        Debug.Log("X: " + x + " - Z: " + z);
    }

    /*
    void CameraWork()
    {
        player.transform.Rotate(Input.GetAxis("Mouse Y") * -turnSpeed * 2.5f * Time.deltaTime, Input.GetAxis("Mouse X") * turnSpeed * 2.5f * Time.deltaTime, 0f);
        Quaternion q = player.transform.rotation;
        q.eulerAngles = new Vector3(PlayerMovement.ClampAngle(q.eulerAngles.x, -90f, 40f), q.eulerAngles.y, 0);
        player.transform.rotation = q;

        private static float ClampAngle(float angle, float min, float max)
        {
            if (min < 0 && max > 0 && (angle > max || angle < min))
            {
                angle -= 360;
                if (angle > max || angle < min)
                {
                    if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))) return min;
                    else return max;
                }
            }
            else if (min > 0 && (angle > max || angle < min))
            {
                angle += 360;
                if (angle > max || angle < min)
                {
                    if (Mathf.Abs(Mathf.DeltaAngle(angle, min)) < Mathf.Abs(Mathf.DeltaAngle(angle, max))) return min;
                    else return max;
                }
            }

            if (angle < min) return min;
            else if (angle > max) return max;
            else return angle;
        }
    }
    */
}
