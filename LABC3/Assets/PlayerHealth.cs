using UnityEngine;
using UnityEngine.Events;  // Bắt buộc import để dùng UnityEvent

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    // UnityEvent thay vì C# event - có thể binding trong Inspector
    public UnityEvent<float> onHealthChanged;  // Truyền normalized health (0..1)

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealth();  // Gọi lần đầu để UI hiện máu đầy
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(20f);
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0) currentHealth = 0;

        float normalized = currentHealth / maxHealth;

        // Gọi UnityEvent - các hàm binding sẽ nhận normalized
        onHealthChanged.Invoke(normalized);

        if (currentHealth <= 0)
        {
            Debug.Log("GAME OVER!");
        }
    }

    private void UpdateHealth()
    {
        float normalized = currentHealth / maxHealth;
        onHealthChanged.Invoke(normalized);
    }
}