using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool gameOver = false;
    public GameObject levelCompleteUI;

    public void levelComplete() {
        Debug.Log("complete!!!");
        levelCompleteUI.SetActive(true);
    }

    public void endGame() {
        if (gameOver == false) {
            gameOver = true;
            Debug.Log("game over");
            Invoke("Restart", 3f);
        }
    }


    private void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}





