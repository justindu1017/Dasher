using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "walls") {
            playerMovement.enabled = false;
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
