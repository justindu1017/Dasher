using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerCollpase : MonoBehaviour
{ 
    public Rigidbody rigidBody;
    public Rigidbody rigidBody1;
    public Rigidbody rigidBody2;
    public Rigidbody rigidBody3;


    private void OnTriggerEnter()
    {
        rigidBody.useGravity = true;
        Invoke("Rigidbody1Fall", 0.5f);
        Invoke("Rigidbody2Fall", 0.8f);
        Invoke("Rigidbody3Fall", 1.1f);
        //rigidBody2.useGravity = true;
        //rigidBody3.useGravity = true;
    }


    private void Rigidbody1Fall() {
        rigidBody1.useGravity = true;
    }
    private void Rigidbody2Fall()
    {
        rigidBody2.useGravity = true;
    }
    private void Rigidbody3Fall()
    {
        rigidBody3.useGravity = true;
    }
}
