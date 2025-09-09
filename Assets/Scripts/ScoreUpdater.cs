using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    private TMP_Text scoreText;
    void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        UpdateScoreText();
    }

    // Update is called once per frame
    private void UpdateScoreText()
    {
        scoreText.text = GlobalScoreManager.GlobalScore.ToString();
    }

    void Update()
    {
        UpdateScoreText();
    }
}
