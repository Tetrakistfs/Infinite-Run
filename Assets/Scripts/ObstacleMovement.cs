using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float fallSpeed = 10f;
    private Rigidbody2D obstacleBody;
    private Vector2 screenBounds;
    void Awake()
    {
        obstacleBody = GetComponent<Rigidbody2D>();
        ObstacleFall();
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void Update()
    {
        // Debug.Log(transform.position.y);
        if (transform.position.y < -screenBounds.y * 1.5)
            Destroy(obstacleBody.gameObject);
    }

    private void ObstacleFall()
    {
        obstacleBody.velocity = Vector2.down * fallSpeed;
        obstacleBody.freezeRotation = true;
    }
}
