using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private GameObject winPanel;

    void Start()
    {
        if (winPanel == null)
        {
            winPanel = GameObject.Find("WinPanel");
        }
    }

    protected override void Die()
    {
        base.Die();

        Debug.Log("Enemy died");

        if (GameManager.Instance != null)
        {
            GameManager.Instance.EnemyKilled();
        }
    }
}