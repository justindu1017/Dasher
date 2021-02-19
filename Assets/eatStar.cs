using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eatStar : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "player") {
            FindObjectOfType<collision>().eatStar();
            FindObjectOfType<starMode>().changeMat();
            this.gameObject.SetActive(false);
        }
    }
}
