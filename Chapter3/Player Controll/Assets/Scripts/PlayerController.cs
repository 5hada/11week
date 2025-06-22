using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float xBound = 4f;

    private Rigidbody playerRb;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
        ContraintPlayerPosition();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(new Vector3(-verticalInput, 0, horizontalInput) * speed);
    }

    void ContraintPlayerPosition()
    {
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }
}
