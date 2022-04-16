using UnityEngine;

public class GameController : MonoBehaviour
{
    private int score;

    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void IncreaseScore()
    {
        score++;
    }
}
