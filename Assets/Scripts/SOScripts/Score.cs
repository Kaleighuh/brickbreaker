using UnityEngine;

[CreateAssetMenu(fileName = "New Score", menuName = "Score")]
public class Score : ScriptableObject
{
    public int currentScore;
    public int highScore;

    public void AddPoints(int points)
    {
        currentScore += points;

        if(currentScore > highScore)
        {
            highScore = currentScore;
        }
    }

    public void ResetScore()
    {
        currentScore = 0;
    }
}