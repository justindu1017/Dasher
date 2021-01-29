using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float zForce = 500f;
    public float xForce = 500f;

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(0, 0, zForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rigidBody.AddForce(xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidBody.AddForce(-xForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rigidBody.position.y < -2f) {
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
