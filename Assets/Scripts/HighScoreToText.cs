using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreToText : MonoBehaviour
{
    private TMP_Text highScoreText;
    void Start()
    {
        highScoreText = GetComponent<TMP_Text>();
        if(PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("score"))
        {
            GlobalScoreManager.SaveHighScore(PlayerPrefs.GetInt("score"));
        }

        int highScore = PlayerPrefs.GetInt("HighScore");

        highScoreText.text = "HighSCore: " + highScore.ToString();
    }

    
}
