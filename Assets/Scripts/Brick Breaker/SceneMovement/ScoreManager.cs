using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    private void Start()
    {
        // Initialize the score text.
        UpdateScoreText();
    }

    // Call this method to add points to the score.
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Update the score text UI.
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}