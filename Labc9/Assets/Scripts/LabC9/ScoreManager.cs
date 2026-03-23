using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        // Lấy từ static
        int score = GameData.score;

        scoreText.text = "Score: " + score;
        Debug.Log("Loaded score: " + score);
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt("HighScore", GameData.score);
        PlayerPrefs.Save();

        Debug.Log("Saved: " + GameData.score);
    }
}