using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOverUI;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "opponent")
        {
            Time.timeScale = 0f;
            gameOverUI.SetActive(true);
        }
    }
}
