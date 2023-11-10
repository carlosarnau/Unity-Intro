using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, player!");

        string playerName = "Twynics";
        int playerHealth = 100;
        float moveSpeed = 5.25f;
        bool gameOver = false;

        Debug.Log(playerName);
        Debug.Log(playerHealth);
        Debug.Log(moveSpeed);
        Debug.Log(gameOver);
    }

    // Update is called once per frame
    void Update()
    {

    }
}