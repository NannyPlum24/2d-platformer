
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinText : MonoBehaviour
{
    Text Text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Text = GetComponent<Text>();
    }
    public int score = 0;
    public Text scoreText;

    void Update()
    {
        UpdateScoreText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}




// Update is called once per frame

