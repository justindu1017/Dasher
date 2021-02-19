using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starMode : MonoBehaviour
{
    float timer;
    Color newColor;
    int index = 0;
    public Material starModeMat;
    public Material originMat;
    public GameObject player;

    public void changeMat() 
    {
        player.GetComponent<MeshRenderer>().material = starModeMat;
    }

    public void starModeOver() 
    {
        player.GetComponent<MeshRenderer>().material = originMat;
        Debug.Log("CMAT");

    }

    private void Update()
    {
        newColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
        //timer += Time.deltaTime;
        if (timer > 1)
        {
            starModeMat.SetColor("_Color", newColor);
            timer = 0;
        }
        timer += Time.deltaTime;

    }

}
