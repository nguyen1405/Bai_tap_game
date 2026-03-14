using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("BattleScene");
    }
    public void OnMainMenuButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}