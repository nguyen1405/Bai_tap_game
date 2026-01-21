using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start()
    {
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    // Public method binding
    public void ShowGameOver(float normalizedHealth)
    {
        if (normalizedHealth <= 0.01f && gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            // Optional: Time.timeScale = 0f; để pause game
        }
    }
}