using UnityEngine;

[CreateAssetMenu(fileName = "New Score", menuName = "Score")]
public class Score : ScriptableObject
{
    public int currentScore;

    public void AddPoints(int points)
    {
        currentScore += points;
        
    }

    public void ResetScore()
    {
        currentScore = 0;
    }
}