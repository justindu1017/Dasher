using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    bool isInvincible = false;

    public void eatStar()
    {
        isInvincible = true;
        Debug.Log("isInvincible" + isInvincible);
        Invoke("starTimeOver", 5f);
    }

    private void starTimeOver()
    {
        FindObjectOfType<starMode>().starModeOver();
        Debug.Log("starTimeOver");
        isInvincible = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag);
        if (collision.collider.tag == "walls" && isInvincible == false)
        {
            playerMovement.enabled = false;
            FindObjectOfType<gameManager>().endGame();
        }
        else if (collision.collider.tag == "walls" && isInvincible == true) {
            collision.gameObject.SetActive(false);
        }

    }
}
