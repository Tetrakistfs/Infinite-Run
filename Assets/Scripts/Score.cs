using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public TMP_Text socreText;
    public TMP_Text highScoreText;
    private int score;

    private int highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "HighScore:" + highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = Mathf.FloorToInt(Time.timeSinceLevelLoad);
        socreText.text = "Score:" + score.ToString();
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore = score;
            highScoreText.text = "HighScore:" + highScore.ToString();
        }

    }
}
