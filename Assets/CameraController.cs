using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Rigidbody body;
    private float moveSpeed = 20f;
    private float horizontalLookSpeed = 2f;
    private float verticalLookSpeed = 2f;
    private float yaw = 0f;
    private float pitch = 0f;

	void Start()
    {
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }
	
	void Update()
    {
        yaw += horizontalLookSpeed * Input.GetAxis("Mouse X");
        pitch -= verticalLookSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0f);

        if (Input.GetKey(KeyCode.W))
        {
            body.velocity = new Vector3(transform.forward.x, transform.forward.y, transform.forward.z * moveSpeed);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            body.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            body.velocity = new Vector3(transform.right.x * moveSpeed, transform.right.y, transform.right.z);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            body.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            body.velocity = new Vector3(-transform.right.x * moveSpeed, -transform.right.y, -transform.right.z);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            body.velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            body.velocity = new Vector3(-transform.forward.x, -transform.forward.y, -transform.forward.z * moveSpeed);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            body.velocity = new Vector3(0, 0, 0);
        }
    }
}
