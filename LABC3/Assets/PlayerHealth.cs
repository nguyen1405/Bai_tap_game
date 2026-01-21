using UnityEngine;
using System; // cho Action

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    // Event mà các Observer sẽ subscribe vào
    public event Action<float> OnHealthChanged; // truyền normalized health (0..1)

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealth(); // thông báo UI lần đầu
    }

    void Update()
    {
        // Test: nhấn phím H để trừ 20 máu
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20f);
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;

        // Thông báo cho tất cả Observer
        float normalized = currentHealth / maxHealth;
        OnHealthChanged?.Invoke(normalized);

        if (currentHealth <= 0)
        {
            Debug.Log("GAME OVER!");
            // Có thể thêm logic khác ở đây
        }
    }

    private void UpdateHealth() // gọi lần đầu
    {
        float normalized = currentHealth / maxHealth;
        OnHealthChanged?.Invoke(normalized);
    }
}