using UnityEngine;

[CreateAssetMenu(fileName = "GameConfig", menuName = "Game/GameConfig")]
public class GameConfig : ScriptableObject
{
    public int playerSpeed;
    public int maxHealth;
    public int startScore;
}