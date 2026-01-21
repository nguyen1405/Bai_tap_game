using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Slider healthSlider; // Kéo Slider UI vào đây trong Inspector

    void Start()
    {
        // Tìm PlayerHealth trong scene và subscribe (đăng ký lắng nghe)
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged += UpdateHealthBar;
        }
        else
        {
            Debug.LogError("Không tìm thấy PlayerHealth trong scene!");
        }
    }

    // Hàm này sẽ được gọi mỗi khi máu thay đổi
    private void UpdateHealthBar(float normalizedHealth)
    {
        if (healthSlider != null)
        {
            healthSlider.value = normalizedHealth; // 0..1
        }
    }

    // Tốt nhất nên unsubscribe khi destroy để tránh lỗi
    void OnDestroy()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged -= UpdateHealthBar;
        }
    }
}