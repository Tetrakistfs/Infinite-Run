using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitBoundaries : MonoBehaviour
{
    // private Camera MainCamera;
    private Vector2 screenBounds;
    private float playerWidth;

    private void Start()
    {
        // MainCamera = Camera.main;
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        playerWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        // Debug.Log(playerWidth);

    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + playerWidth, screenBounds.x - playerWidth);
        transform.position = viewPos;
    }
}
