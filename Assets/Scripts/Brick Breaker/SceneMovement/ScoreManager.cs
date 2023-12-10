using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI highscoreText;
    private int score = 0;
    //private int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        score = 0;
        //scoreText.text = score.ToString() + "POINTS:";
        //highscoreText.text = "HIGHSCORE:" + highscore.ToString();
        // Initialize the score text.
        //UpdateScoreText();
    }

    public void AddPoints(int newScore)
    {
        score += newScore;
        //scoreText.text = score.ToString() + "POINTS:";
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: 0" + score;
    }

    void Update()
    {
        UpdateScore();
    }
}