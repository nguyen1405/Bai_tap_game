using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject winPanel;
    public int enemiesToWin = 5;

    int enemiesKilled = 0;
    bool gameEnded = false;

    void Awake()
    {
        Instance = this;
    }

    public void EnemyKilled()
    {
        if (gameEnded) return;

        enemiesKilled++;

        if (enemiesKilled >= enemiesToWin)
        {
            WinGame();
        }
    }
    void WinGame()
    {
        gameEnded = true;

        if (winPanel != null)
        {
            winPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

}