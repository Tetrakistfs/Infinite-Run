using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collisionDetection : MonoBehaviour
{
    Canvas gameCanvas;

    void Start()
    {
        gameCanvas = FindObjectOfType<Canvas>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Debug.Log("Collision");
        // Debug.Log(collision.gameObject.name);
        Time.timeScale = 0f;
        gameCanvas.GetComponent<PauseMenu>().Lose();

    }
}
