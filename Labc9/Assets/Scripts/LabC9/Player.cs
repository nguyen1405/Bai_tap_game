using UnityEngine;

public class Player : MonoBehaviour
{
    public GameConfig config;

    void Start()
    {
        Debug.Log("Speed: " + config.playerSpeed);
        Debug.Log("Health: " + config.maxHealth);
    }
}