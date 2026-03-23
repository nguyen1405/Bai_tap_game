using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        GameData.score = 12;
        SceneManager.LoadScene("Game");
    }
}