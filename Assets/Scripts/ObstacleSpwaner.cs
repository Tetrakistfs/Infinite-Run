using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpwaner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector2 screenBounds;
    private float spwanTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // Debug.Log(screenBounds.y);
        StartCoroutine(Spawner());
    }

    private void SpwanObstacle()
    {
        GameObject obstacleObject = Instantiate(obstaclePrefab) as GameObject;
        obstacleObject.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1);
    }

    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spwanTime);
            SpwanObstacle();
        }
    }
}
