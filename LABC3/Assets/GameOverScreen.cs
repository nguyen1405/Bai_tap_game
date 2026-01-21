using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameOverPanel; // Kéo Panel UI GameOver vào đây

    void Start()
    {
        // Ẩn panel lúc đầu
        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged += CheckGameOver;
        }
    }

    private void CheckGameOver(float normalizedHealth)
    {
        if (normalizedHealth <= 0f && gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            // Có thể pause game: Time.timeScale = 0;
        }
    }

    void OnDestroy()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged -= CheckGameOver;
        }
    }
}