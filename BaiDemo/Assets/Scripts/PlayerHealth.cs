using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private GameObject losePanel;

    protected override void Die()
    {
        base.Die(); 
        
        Debug.Log("Player died");

        if (losePanel != null)
        {
            losePanel.SetActive(true);
        }
        else
        {
        }
    }
}