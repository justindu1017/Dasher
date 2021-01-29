using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completeTrigger : MonoBehaviour
{
    public gameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.levelComplete();
    }
}
